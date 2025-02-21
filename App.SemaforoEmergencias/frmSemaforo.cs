using Ent.Sql.ClinicaE.HospitalE;
using Bus.Clinica;
using Bus.Utilities;
using System.Globalization;

namespace App.SemaforoEmergencias
{
    public partial class frmSemaforo : Form
    {
        public int tiempo = 60, Contador = 0;

        private SemaforoE oSemaforoE = new SemaforoE(1, "E", "09", "", "");
        private List<SemaforoE> oListaSemaforo;
        private CultureInfo provider = CultureInfo.InvariantCulture;

        public frmSemaforo()
        { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e)
        {

            Forms.FormAlwaysVisible(1);

            //Coloca Ventana en la parte superior derecha
            Screen scr = Screen.FromPoint(Location);
            Location = new Point(scr.WorkingArea.Right - Width, scr.WorkingArea.Top);

            //Tamaño del formulario
            //Size = new Size(587, 148);

            //Cabecera del Formulario
            this.Text = "CSF - Semaforo de Emergencia  [" + Bus.Utilities.ConnectionsString.Server + "]";

            //Carga Grilla y Label
            CargaGrLb();

        }

        private void CargaGrLb()
        {
            //Carga los Label
            oSemaforoE.Orden = 2;
            CargarLb();

            //Carga la Grilla
            oSemaforoE.Orden = 1;
            CargarGrilla();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        { VerLista(); }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Contador++;
            if (tiempo == Contador)
            {
                oSemaforoE.Buscar = "";
                CargaGrLb();
                Contador = 0;
            }
            lbTimer.Text = "La Información se actualizará en: " + (tiempo - Contador);
            lbHora.Text = DateTime.Now.ToString("hh:mm tt");

        }
        private void BtnCasa_Click(object sender, EventArgs e)
        {
            Size = new Size(this.Width, 370);
            rjButton1.Text = "↑ Lista ↑";

            oSemaforoE.Buscar = "CASA";
            CargaGrLb();
            Contador = 0;
        }
        private void BtnHospitalizacion_Click(object sender, EventArgs e)
        {

            Size = new Size(this.Width, 370);
            rjButton1.Text = "↑ Lista ↑";

            oSemaforoE.Buscar = "HOSPITALIZACION";
            CargaGrLb();
            Contador = 0;
        }
        private void BtnFallecido_Click(object sender, EventArgs e)
        {

            Size = new Size(this.Width, 370);
            rjButton1.Text = "↑ Lista ↑";

            oSemaforoE.Buscar = "FALLECIDO";
            CargaGrLb();
            Contador = 0;
        }

        private void BtnReferido_Click(object sender, EventArgs e)
        {

            Size = new Size(this.Width, 370);
            rjButton1.Text = "↑ Lista ↑";

            oSemaforoE.Buscar = "REFERIDOS";
            CargaGrLb();
            Contador = 0;
        }

        private void VerLista()
        {
            oSemaforoE.Buscar = "";
            if (Size == new Size(this.Width, 103))
            {
                Size = new Size(this.Width, 280);
                rjButton1.Text = "↑ Lista ↑";

                CargaGrLb();
            }
            else
            {
                Size = new Size(this.Width, 103);
                rjButton1.Text = "↓ Lista ↓";
            }
        }
        private void CargarLb()
        {
            oListaSemaforo = new Otros().ListaSemanforoEmergencias(oSemaforoE);

            for (int i = 0; i < oListaSemaforo.Count; i++)
            {
                if (oListaSemaforo[i].Semaforo == "CASA")
                { BtnCasa.Text = oListaSemaforo[i].Cantidad.ToString(); }

                if (oListaSemaforo[i].Semaforo == "REFERIDOS")
                { BtnReferido.Text = oListaSemaforo[i].Cantidad.ToString(); }

                if (oListaSemaforo[i].Semaforo == "HOSPITALIZACION")
                { BtnHospitalizacion.Text = oListaSemaforo[i].Cantidad.ToString(); }

                if (oListaSemaforo[i].Semaforo == "FALLECIDO")
                { BtnFallecido.Text = oListaSemaforo[i].Cantidad.ToString(); }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oSemaforoE.Buscar = "";
            CargaGrLb();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarGrilla()
        {

            oListaSemaforo = new Otros().ListaSemanforoEmergencias(oSemaforoE);
            ListViewItem item = new ListViewItem();
            ListView1.Items.Clear();

            for (int i = 0; i < oListaSemaforo.Count; i++)
            {
                //DateTime xdateTime = DateTime.ParseExact(oListaSemaforo[i].FechaAltamedica, "d/M/yyyy h:mm:ss tt", provider);
                var horas = (DateTime.Now - DateTime.ParseExact(oListaSemaforo[i].FechaAltamedica, "d/M/yyyy h:mm:ss tt", provider)).ToString(@"dd\d\ hh\h\ mm\m\ ");
                if (oListaSemaforo[i].Semaforo == "CASA")
                {
                    item = ListView1.Items.Add(oListaSemaforo[i].Cama);
                    item.SubItems.Add(oListaSemaforo[i].CodAtencion);
                    item.SubItems.Add(oListaSemaforo[i].Prioridad);
                    item.SubItems.Add(oListaSemaforo[i].NombreDestino);
                    item.SubItems.Add(horas);
                    //item.ForeColor = Color.Green;
                    item.ForeColor = Color.White;
                    item.BackColor = Color.Green;

                }
                if (oListaSemaforo[i].Semaforo == "REFERIDOS")
                {
                    item = ListView1.Items.Add(oListaSemaforo[i].Cama);
                    item.SubItems.Add(oListaSemaforo[i].CodAtencion);
                    item.SubItems.Add(oListaSemaforo[i].Prioridad);
                    item.SubItems.Add(oListaSemaforo[i].NombreDestino);
                    item.SubItems.Add(horas);
                    item.ForeColor = Color.White;
                    item.BackColor = Color.Blue;
                }
                if (oListaSemaforo[i].Semaforo == "HOSPITALIZACION")
                {
                    item = ListView1.Items.Add(oListaSemaforo[i].Cama);
                    item.SubItems.Add(oListaSemaforo[i].CodAtencion);
                    item.SubItems.Add(oListaSemaforo[i].Prioridad);
                    item.SubItems.Add(oListaSemaforo[i].NombreDestino);
                    item.SubItems.Add(horas);
                    item.ForeColor = Color.White;
                    item.BackColor = Color.Red;
                }
                if (oListaSemaforo[i].Semaforo == "FALLECIDO")
                {
                    item = ListView1.Items.Add(oListaSemaforo[i].Cama);
                    item.SubItems.Add(oListaSemaforo[i].CodAtencion);
                    item.SubItems.Add(oListaSemaforo[i].Prioridad);
                    item.SubItems.Add(oListaSemaforo[i].NombreDestino);
                    item.SubItems.Add(horas);
                    item.ForeColor = Color.White;
                    item.BackColor = Color.Black;
                }
            }
        }
    }
}
