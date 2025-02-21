////using Bus.AgendaClinica;
////using Bus.AgendaClinica.Clinica;
using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.MedicosE;
using Ent.Sql.ClinicaE.MedisynE;
using Ent.Sql.ClinicaE.OtrosE;
//using Microsoft.Extensions.Configuration;
//using static Bus.AgendaClinica.Clinica.AgendaCitas;

namespace App.Clinica
{
    public class UtilWinForm
    {
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

        /// <summary>
        /// /
        /// </summary>
        /// <param name="grdC"></param>
        /// <param name="twoDim"></param>
        public void FmtGrd(System.Windows.Forms.DataGridView grdC, string[,] twoDim)
        {
            int limite;
            string NombreCampo, TituloCampo;
            int LongitudCampo, AlineaCampo;
            for (int i = 0; i != twoDim.GetLength(0); ++i)
            {
                NombreCampo = twoDim[i, 0].ToString();
                TituloCampo = twoDim[i, 1].ToString();
                LongitudCampo = Int32.Parse(twoDim[i, 2].ToString());
                AlineaCampo = Int32.Parse(twoDim[i, 3].ToString());

                grdC.AutoGenerateColumns = false;

                grdC.Columns.Add(NombreCampo, TituloCampo);
                grdC.Columns[NombreCampo].DataPropertyName = NombreCampo;
                grdC.Columns[NombreCampo].Width = LongitudCampo;
            }
            if (grdC.Rows.Count > 0)
            {
                //grdC.Rows[0].Selected = true;
                //grdC.Rows[0].Activate();
            }
        }

    }
}
