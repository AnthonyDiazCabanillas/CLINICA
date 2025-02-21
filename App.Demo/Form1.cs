using Bus.AgendaClinica;
using Bus.AgendaClinica.Clinica;
using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.MedicosE;
using Ent.Sql.ClinicaE.MedisynE;
using Ent.Sql.ClinicaE.OtrosE;
using Microsoft.Extensions.Configuration;
using static Bus.AgendaClinica.Clinica.AgendaCitas;

namespace App.Demo
{
    public partial class Form1 : Form
    {
        Generales oGenerales;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oGenerales = new Generales();

            this.Text = this.Text + " : " + Bus.Utilities.ConnectionsString.Server + " : : " + VariablesGlobales.CodUser + "";

            this.dtpFecInicio.MinDate = Convert.ToDateTime("01/06/2020");
            this.dtpFecInicio.Value = DateTime.Now;

            this.dtpFecFin.MinDate = Convert.ToDateTime("01/06/2020");
            this.dtpFecFin.Value = DateTime.Now;

            MtdCargarCombo(cboSede, "nombre", "codigo", "SEDE_CITAAMB", "", true);
            MtdCargarCombo(cboTipoConsulta, "nombre", "codigo", "MEDISYN_ESTADO_CONSULTA_MEDICA", "", true);
            MtdCargarCombo(cboTipoPago, "nombre", "codigo", "MEDISYN_TIPO_PAGO", "", true);

            pConfiguraGrilla();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgendaCitas agendaCitas = new AgendaCitas();
            string sedesXML = agendaCitas.fnObtenerSedes();

            //MedicosE oMedicosE = new MedicosE("", 0, 25, 19);
            //oListaMedicos = new Bus.Clinica.Medicos().ConsultarMedicos(oMedicosE);

        }


        public void CargarGrillaDatosReserva()
        {
            string CodSede = "";
            if (cboSede.Items.Count != 0)
                CodSede = cboSede.SelectedValue == null ? "" : cboSede.SelectedValue.ToString();

            List<MdsynAmReservaE> oList = new List<MdsynAmReservaE>();

            MdsynAmReservaE oMdsynAmReservaE = new MdsynAmReservaE(0, 0, dtpFecInicio.Value.ToString("MM/dd/yyyy"), dtpFecFin.Value.ToString("MM/dd/yyyy"), CodSede, txtPaciente.Text, txtDocIdentidad.Text, "", "8");
            oMdsynAmReservaE.CodTipoConsultaMedica = cboTipoConsulta.SelectedValue == null ? "" : this.cboTipoConsulta.SelectedValue.ToString();
            oMdsynAmReservaE.CodTipoPago = cboTipoPago.SelectedValue == null ? "" : this.cboTipoPago.SelectedValue.ToString();
            oMdsynAmReservaE.CodAtencion = txtCodAtencion.Text;

            oList = oGenerales.Sp_MdsynAmReserva_Consulta(oMdsynAmReservaE);

            dgvResultadoConsulta.DataSource = oList;

            MessageBox.Show("Se encontraron " + oList.Count.ToString() + " registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pConfiguraGrilla()
        {
            dgvResultadoConsulta.AutoGenerateColumns = false;

            string[,] fmtGrd = {

                            {"IDCita", "IDCita", "90","1"},
                            {"FecCita", "FecCita", "90","1"},
                            {"CodAtencion", "CodAtencion", "90","1"},

                            {"RutPaciente", "Doc. Ident.", "115","0"},
                            {"NombresPaciente", "Paciente", "93","0"},
                            {"DscSede", "Sede", "71","0"},

                            {"DscEspecialidad", "Especialidad", "120","0"},
                            {"DscTipoConsultaMedica", "Consulta Médica", "150","0"},
                            {"DscTipoPago", "Tipo Pago", "105","0"},

                            {"NombresMedico", "Medico", "80","0"},
                            {"FecRegistro", "Fec. Registro", "130","0"},
                            {"UsrRegistroPlataforma", "Plataforma", "110","0"},

                            {"Telefono", "Telefono", "90","0"},
                            {"Email", "Correo", "90","0"},
                            {"FecAnulacion", "Fecha Anulación", "90","0"},

                            {"Moneda", "Moneda", "90","0"},
                            {"Monto", "Monto", "90","0"},
                            {"NroOperacion", "NroOperacion", "130","0"},

                        };
            FmtGrd(dgvResultadoConsulta, fmtGrd);



        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


       public void MtdCargarCombo(System.Windows.Forms.ComboBox pCombo, string pDisplayMember = "nombre", string pValueMember = "codigo", string pCodTabla = "", object pLista = null, bool pCampoBlanco = false)
        {
            if (!string.IsNullOrEmpty(pCodTabla))
            {
                var oList = new List<TablasE>();
                var oListResult = new List<TablasE>();
                oList = new TablasAD().Sp_Tablas_Consulta(new TablasE(pCodTabla, "", 0, 0, 19));
                if (pCampoBlanco == true)
                {
                    oListResult.Add(new TablasE());
                    for (int i = 0, loopTo = oList.Count - 1; i <= loopTo; i++)
                        oListResult.Add(oList[i]);
                }
                else
                {
                    oListResult = oList;
                }

                pLista = oListResult;
            }

            pCombo.DataSource = pLista;
            pCombo.DisplayMember = pDisplayMember;
            pCombo.ValueMember = pValueMember;

            if (pCombo.Items.Count != 0) // Poner por defecto el valor "0"
            {
                pCombo.SelectedIndex = 0;
            }
        }
         public void FmtGrd(System.Windows.Forms.DataGridView grdC, string[,] twoDim)
        {
            int limite;
            string NombreCampo, TituloCampo;
            //Boolean Visible;
            int LongitudCampo, AlineaCampo;
            //int numero;
            //limite = grdC.DisplayLayout.Bands[0].Columns.All.Count();

            //for (int i = 0; i != limite; ++i)
            //{
            //    grdC.DisplayLayout.Bands[0].Columns[i].Hidden = true;
            //    grdC.DisplayLayout.Bands[0].Columns[i].MergedCellStyle = MergedCellStyle.Never;
            //}

            for (int i = 0; i != twoDim.GetLength(0); ++i)
            {
                NombreCampo = twoDim[i, 0].ToString();
                TituloCampo = twoDim[i, 1].ToString();
                LongitudCampo = Int32.Parse(twoDim[i, 2].ToString());
                AlineaCampo = Int32.Parse(twoDim[i, 3].ToString());
                //numero = Int32.Parse(twoDim[i, 4].ToString());

                //grdC.DisplayLayout.Bands[0].Columns[NombreCampo].Hidden = LongitudCampo == 0 ? true : false;
                //grdC.DisplayLayout.Bands[0].Columns[NombreCampo].Header.VisiblePosition = i + 1;
                //grdC.DisplayLayout.Bands[0].Columns[NombreCampo].Header.Caption = TituloCampo;
                //grdC.DisplayLayout.Bands[0].Columns[NombreCampo].Width = LongitudCampo;
                //grdC.DisplayLayout.Bands[0].Columns[NombreCampo].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
                //grdC.DisplayLayout.Bands[0].Columns[NombreCampo].CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect; //.RowSelect;
                //grdC.DisplayLayout.Bands[0].Columns[NombreCampo].CellAppearance.TextHAlign = Alineacion[AlineaCampo];

                dgvResultadoConsulta.AutoGenerateColumns = false;

                dgvResultadoConsulta.Columns.Add(NombreCampo, TituloCampo);
                dgvResultadoConsulta.Columns[NombreCampo].DataPropertyName = NombreCampo;
                dgvResultadoConsulta.Columns[NombreCampo].Width = LongitudCampo;
                //dgvResultadoConsulta.Columns[NombreCampo].ali

                //dgvResultadoConsulta.Columns.Add("IDCita", "Cita");
                //dgvResultadoConsulta.Columns.Add("FecCita", "Fec. Cita");
                //dgvResultadoConsulta.Columns.Add("CodAtencion", "Cod. Atencion");

                //dgvResultadoConsulta.Columns["IDCita"].DataPropertyName = "IDCita";
                //dgvResultadoConsulta.Columns["FecCita"].DataPropertyName = "FecCita";
                //dgvResultadoConsulta.Columns["CodAtencion"].DataPropertyName = "CodAtencion";


                //string typeField = grdC.DisplayLayout.Bands[0].Columns[NombreCampo].DataType.ToString().ToUpper();

                //if (numero == 1)
                //{
                //    grdC.DisplayLayout.Bands[0].Columns[NombreCampo].Format = "###,##0.00";
                //}
            }
            if (grdC.Rows.Count > 0)
            {
                //grdC.Rows[0].Selected = true;
                //grdC.Rows[0].Activate();
            }
            //grdC.Selected.Rows.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dgvResultadoConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDocIdentidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTraeData_Click(object sender, EventArgs e)
        {
            CargarGrillaDatosReserva();
        }

        private void btnProcesarPago_Click(object sender, EventArgs e)
        {
            oGenerales.mtProcesarPagos();
        }



    }
}
