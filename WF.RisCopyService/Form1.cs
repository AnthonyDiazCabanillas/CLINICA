using Bus.RisClinica.RisClinica;
using System.Diagnostics;

namespace WF.RisCopyService
{
    public partial class Form1 : Form
    {
        GeneralesRisCopyService oGRCS = new GeneralesRisCopyService();


        private static System.Timers.Timer timer;

        public Form1()
        {
           
            InitializeComponent();
            //timerx();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //oGRCS.GrabarLog("prueba 2");
            oGRCS.CopiarRis();
            oGRCS.FormatearXMLAgendamiento();
            oGRCS.CopiarRISCompletado();
            oGRCS.FormatearXMLCompletado();
            oGRCS.CopiarPDF();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            oGRCS.CopiarRis();
            oGRCS.FormatearXMLAgendamiento();
            oGRCS.CopiarRISCompletado();
            oGRCS.FormatearXMLCompletado();
            oGRCS.CopiarPDF();
        }

        private void timerx()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 50;
            timer.Elapsed += timer1_Tick;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
    }
}