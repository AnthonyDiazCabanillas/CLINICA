using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ent.Sql.ClinicaE.MedisynE;
using Bus.AgendaClinica;
using static Bus.AgendaClinica.Clinica.VariablesGlobales;
using Ent.Sql.ClinicaE.OtrosE;
using Bus.AgendaClinica.Clinica;

namespace App.Clinica.Cita
{
    public partial class frmDatosReserva : Form
    {
        UtilWinForm utilWF = new UtilWinForm();
        Generales oGenerales;
        bool form_started = false;


        public frmDatosReserva()
        {
            InitializeComponent();
        }

        private void frmDatosReserva_Load(object sender, EventArgs e)
        {
            Load_Initial_Synapsis();

            this.Text = this.Text + " : " + Bus.Utilities.ConnectionsString.Server + " : : ";// + VarGlobal.CodAtencion + "";

            //txtDocIdentidad.Text = VarGlobal.DocIdentidad;

            oGenerales = new Generales();

            dtpFecInicio.MinDate = DateTime.Now;
            dtpFecInicio.Value = DateTime.Now;

            dtpFecFin.MinDate = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            dtpFecFin.Value = Convert.ToDateTime(DateTime.Now.ToString("01/MM/yyyy")).AddMonths(1).AddDays(-1);

            utilWF.MtdCargarCombo(cboSede, "nombre", "codigo", "SEDE_CITAAMB", "", true);

            pConfiguraGrilla();
            CargarGrillaDatosReserva();
            form_started = true;
        }

        public void CargarGrillaDatosReserva()
        {
            string CodSede = "";
            if (cboSede.Items.Count != 0)
                CodSede = cboSede.SelectedValue == null ? "" : cboSede.SelectedValue.ToString();

            List<MdsynAmReservaE> oList = new List<MdsynAmReservaE>();
            //oList = oGenerales.Sp_MdsynAmReserva_Consulta(new MdsynAmReservaE(0, 0, dtpFecInicio.Value.ToString("MM/dd/yyyy"), dtpFecFin.Value.ToString("MM/dd/yyyy"), CodSede, txtPaciente.Text, txtDocIdentidad.Text, "", "2"));
            oList = oGenerales.Sp_Mdsyn_Cita_Consulta(new MdsynAmReservaE(0, 0, dtpFecInicio.Value.ToString("MM/dd/yyyy"), dtpFecFin.Value.ToString("MM/dd/yyyy"), CodSede, txtPaciente.Text, txtDocIdentidad.Text, "", "2"));

            
            dgvResultadoConsulta.AutoGenerateColumns = false;
            dgvResultadoConsulta.DataSource = oList;

            if (oList.Count >= 25)
                MessageBox.Show("Por favor sea más exacto es su búsqueda, solo se muestran los primeros 25 registros de la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrillaDatosReserva();
        }

        private void pConfiguraGrilla()
        {
            dgvResultadoConsulta.AutoGenerateColumns = false;

            string[,] fmtGrd = {

                            {"IdePagosBot", "Id. Pago", "90","0"},
                            {"IdeReserva", "Id Rsv.", "90","0"},
                            {"IdeCorrelReserva", "Correl Res.", "115","0"},

                            {"FecRegistro", "Fec. Registro", "120","0"},
                            {"RutPaciente", "Doc. Ident.", "115","0"},
                            {"NombresPaciente", "Paciente", "130","0"},

                            {"DscSede", "Sede", "90","0"},
                            {"DscEspecialidad", "Especialidad", "120","0"},
                            {"DscTipoConsultaMedica", "Cons. Méd.", "115","0"},

                            {"NombresMedico", "Medico", "130","0"},
                            {"FecCita", "Fec. Cita", "90","0"},
                            {"Telefono", "Teléfono", "90","0"},

                            {"Telefono2", "Teléfono 2", "90","0"},
                            {"UsrRegistroPlataforma", "Plataforma", "120","0"},


                            //{"XXXXX", "XXXXX", "90","0"},
                            //{"XXXXX", "XXXXX", "90","0"},
                        };
            utilWF.FmtGrd(dgvResultadoConsulta, fmtGrd);

        }


    }
}
