//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         09/08/2024     HVIDAL       REQ 2024-011506 
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalDocE
{
    public class HospitalDocE
    {
        private int _id_documento = 0;
        public int id_documento
        {
            get
            {
                return _id_documento;
            }
            set
            {
                _id_documento = value;
            }
        }

        private string _nuevo_valor = "";
        public string nuevo_valor
        {
            get
            {
                return _nuevo_valor;
            }
            set
            {
                _nuevo_valor = value;
            }
        }

        private byte[]? _blb_documento = new byte[0];
        public byte[]? blb_documento
        {
            get
            {
                return _blb_documento;
            }
            set
            {
                _blb_documento = value;
            }
        }

        private string _campo = "";
        public string campo
        {
            get
            {
                return _campo;
            }
            set
            {
                _campo = value;
            }
        }

        public HospitalDocE()
        {
        }

        public HospitalDocE(int pid_documento, string pnuevo_valor, byte[] pblb_documento,string pcampo)
        {
            id_documento = pid_documento;
            nuevo_valor = pnuevo_valor;
            blb_documento = pblb_documento;
            campo = pcampo;
        }
    }
}
