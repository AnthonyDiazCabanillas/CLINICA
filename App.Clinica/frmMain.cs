namespace App.Clinica
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPagoReserva_Click(object sender, EventArgs e)
        {
            Cita.frmDatosReserva ofrmDatosReserva = new Cita.frmDatosReserva();
            //VarGlobal.CodLiquidacion = "0004745312"; // "0004611485";
            //VarGlobal.MontoTotalPagar = 100.01;
            //VarGlobal.TipoPago = ListTipoPagoOrdenBot.Reserva;
            //VarGlobal.CodAtencion = ""; //"A1197686";
            ofrmDatosReserva.Show();
        }

        private void btnSiteds_Click(object sender, EventArgs e)
        {
            Cita.frmSiteds ofrmSiteds = new Cita.frmSiteds();
            ofrmSiteds.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}