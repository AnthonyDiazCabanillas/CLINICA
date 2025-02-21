using Dat.Sql.LogisticaAD.ConveniosAD;
using Ent.Sql;
using Ent.Sql.LogisticaE.ConveniosE;

namespace Bus.Clinica.Logistica
{
    public class Convenios
    {
        public List<ConveniosE> ListaConvenios(ConveniosE pConveniosE)
        {
            try
            { return new ConveniosAD().Sp_Convenios_ConsultaV2(pConveniosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool InsertarConvenio(ConveniosE pConveniosE)
        {
            try
            { return new ConveniosAD().Sp_Convenios_Insert(pConveniosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public ResultadoTransactionE<ErrorDataInsercionE> Sp_Convenios_Insert_Masivo(List<ConveniosE> objconvenios) {
            return new ConveniosAD().Sp_Convenios_Insert_Masivo(objconvenios);
        }

        public bool ActualizarxCampoConvenio(ConveniosE pConveniosE)
        {
            try
            { return new ConveniosAD().Sp_Convenios_UpdatexCampo(pConveniosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

    }
}
