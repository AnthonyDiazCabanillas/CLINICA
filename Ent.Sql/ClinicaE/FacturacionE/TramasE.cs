using Ent.Sql.ClinicaE.SitedsE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE
{/********************************************************************************************************************
        Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

        Version  Fecha        Autor           Requerimiento
        1.0      23/01/2025   FCHUJE          REQ 2025-002354 Opción de modificar en HIS la cabecera de tramas
        ********************************************************************************************************************/
    public class TramasE
    {
        public int Iduser { get; set; }
        public List<MecCabeceraDocumentoE> Mec_CabeceraDocumento {  get; set; }
        public List<MEcCabeceraAtencionE> Mec_CabeceraAtencion { get; set; }
        public List<MecDetalleServiciosE> Mec_DetalleServicios { get; set; }
        public List<MecDetalleProductosFarmacia> Mec_DetalleProductosFarmacia { get; set; }
        public List<MecCoaSegurosE> Mec_Coaseguros { get; set; }
        public MecMensajeE Mec_MensajeTrama { get; set; }
        
    }

    public class MecCabeceraDocumentoE 
    {
        public string fechaenvio { get; set; }
        public string horaenvio { get; set; }
        public string numerolote { get; set; }
        public string codigofinanciador { get; set; }
        public string rucfacturador { get; set; }
        public string sedefacturador { get; set; }
        public string tipodocumentopago { get; set; }
        public string numerodocumentopago { get; set; }
        public string fechaemision { get; set; }
        public string producto { get; set; }
        public string cantidadatencionesxdoc { get; set; }
        public string codigomecanismopago { get; set; }
        public string codsubtipomecanismopago { get; set; }
        public string montoprepactado { get; set; }
        public string fechaperiodoprepactado { get; set; }
        public string tipomoneda { get; set; }
        public string montoservfar_exoneradoigv { get; set; }
        public string montocopagofijo { get; set; }
        public string montocopagofijo_exoneradoigv { get; set; }
        public string montocopagovariable { get; set; }
        public string montocopagovariable_exoneradoigv { get; set; }
        public string montoneto { get; set; }
        public string igvmontoneto { get; set; }
        public string montonetofacturar { get; set; }
         
    }

    public class MEcCabeceraAtencionE
    {
        public string rucfacturador { get; set; }
        public string sedefacturador { get; set; }
        public string tipodocumentopago { get; set; }
        public string numerodocumentopago { get; set; }
        public string correlativoatencion { get; set; }
        public string codigoatencion { get; set; }
        public string tiposeguropaciente { get; set; }
        public string codigopacienteasegurado { get; set; }
        public string tipdocidentidad { get; set; }
        public string docidentidad { get; set; }
        public string numerohistoriaclinica { get; set; }
        public string tipodocumentoatencion { get; set; }
        public string numerodocumentoatencion { get; set; }
        public string segtipodocumentoatencion { get; set; }
        public string segnumerodocumentoatencion { get; set; }
        public string tipocobertura { get; set; }
        public string subtipocobertura { get; set; }
        public string coddiagnostico1 { get; set; }
        public string coddiagnostico2 { get; set; }
        public string coddiagnostico3 { get; set; }
        public string fechainicioatencion { get; set; }
        public string horainicioatencion { get; set; }
        public string codtipoprofesionalrespon { get; set; }
        public string numeroprofesionalrespon { get; set; }
        public string tipodocidentidadprof { get; set; }
        public string docidentidadprof { get; set; }
        public string rucentidadreferencia { get; set; }
        public string fechareferencia { get; set; }
        public string horareferencia { get; set; }
        public string tipohospitalizacion { get; set; }
        public string fechaingresohospitalario { get; set; }
        public string fechaegresohospitalario { get; set; }
        public string tipoegresohospitalario { get; set; }
        public string diasestaciafacturable { get; set; }
        public string gastohonorario_sinigv { get; set; }
        public string gastoodontologo_sinigv { get; set; }
        public string gastohoteleria_sinigv { get; set; }
        public string gastolaboratorio_sinigv { get; set; }
        public string gastoimagenes_sinigv { get; set; }
        public string gastofarmacia_sinigv { get; set; }
        public string gastoprotesis_sinigv { get; set; }
        public string gastofarmacia_exoneradoigv { get; set; }
        public string gastootros_sinigv { get; set; }
        public string copagofijo_sinigv { get; set; }
        public string copagofijo_exoneradoigv { get; set; }
        public string copagovariable_sinigv { get; set; }
        public string copagovariable_exoneradoigv { get; set; }
        public string montoatencion { get; set; }
        /*[1.0] INI*/
        public bool update { get; set; } = false;

        public double Monto_suma_servicio()
        {
            return Math.Round((
                       Convert.ToDouble(gastohonorario_sinigv) +
                       Convert.ToDouble(gastoodontologo_sinigv) +
                       Convert.ToDouble(gastohoteleria_sinigv) +
                       Convert.ToDouble(gastolaboratorio_sinigv) +
                       Convert.ToDouble(gastoimagenes_sinigv) +
                       Convert.ToDouble(gastofarmacia_sinigv) +
                       Convert.ToDouble(gastoprotesis_sinigv) +
                       Convert.ToDouble(gastofarmacia_exoneradoigv) +
                       Convert.ToDouble(gastootros_sinigv)), 2);
        }
        public double Monto_suma_copagos()
        {
            return Math.Round((
                    Convert.ToDouble(copagofijo_sinigv) +
                    Convert.ToDouble(copagofijo_exoneradoigv) +
                    Convert.ToDouble(copagovariable_sinigv) +
                    Convert.ToDouble(copagovariable_exoneradoigv)
                  ));
        }
        public double MontoDif_Servicio_Copago()
        {
            return Math.Round((Monto_suma_servicio() - Monto_suma_copagos()), 2);
        }

        public double MontoDif_MontoServicio_Copago()
        {
            return Math.Round((Convert.ToDouble(montoatencion) - Monto_suma_copagos()), 2);
        }

        public double SumMonto_Documento_Copago(double monto)
        {
            return Math.Round((monto + Monto_suma_copagos()), 2);
        }
        /*[1.0] FIN*/
    }

    public class MecDetalleServiciosE {
        public string rucfacturador {  get; set; }
        public string sedefacturador { get; set; }
        public string tipodocumentopago { get; set; }
        public string numerodocumentopago { get; set; }
        public string correlativoatencion { get; set; }
        public string correlativo { get; set; }
        public string tipoclasificaciongasto { get; set; }
        public string codigoclasificaciongast { get; set; }
        public string nombreprestacion { get; set; }
        public string fechaefectuadoservicio { get; set; }
        public string codtipoprofesionalrespon { get; set; }
        public string numeroprofesionalrespon { get; set; }
        public string tipodocidentidadprof { get; set; }
        public string docidentidadprof { get; set; }
        public string cantidadrepservicios { get; set; }
        public string preciounitario { get; set; }
        public string copagovariable { get; set; }
        public string copagofijo { get; set; }
        public string montoservicio { get; set; }
        public string montonocubiertoservicio { get; set; }
        public string diagnosticoasociado { get; set; }
        public string servicioexentoimpuesto { get; set; }
        public string codrubro { get; set; }
        public string grup_suna { get; set; }
        public string grup_sunasa {  get; set; }

        public bool Update {  get; set; } = false;


        public double CantidadXMonto() {
            return Math.Round((Convert.ToDouble(cantidadrepservicios) * Convert.ToDouble(preciounitario)), 2);
        }

    }
    public class MecDetalleProductosFarmacia {
        public string rucfacturador { get; set; }
        public string sedefacturador { get; set; }
        public string tipodocumentopago { get; set; }
        public string numerodocumentopago { get; set; }
        public string correlativoatencion { get; set; }
        public string correlativoproducto { get; set; }
        public string tipoproducto { get; set; }
        public string codigoproducto { get; set; }
        public string codprod_digemid { get; set; }
        public string fechaemision { get; set; }
        public string cantidadventa { get; set; }
        public string preciounitario { get; set; }
        public string copagoproducto { get; set; }
        public string montoporproducto { get; set; }
        public string montonocubiertoproducto { get; set; }
        public string diagnosticoasociado { get; set; }
        public string productoexentoimpuesto { get; set; }
        public string codguia { get; set; }
        public bool update {  get; set; } = false;

        public double CantXPrecioFarmacia() {

            return Math.Round((Convert.ToDouble(cantidadventa) * Convert.ToDouble(preciounitario)),2);
        }
    }

    public class MecMensajeE 
    {
        public string Mensaje { get; set; }
    }

    public class MecCoaSegurosE 
    {
        public double CoaseguroPoliza {  get; set; }
        public double CoaseguroDetalleComprobante { get; set; }
        public double CoaseguroPresotor {  get; set; }
        public double CoaseguroVenta { get; set; }
        public string CodPresotor { get; set; }
        public bool Alerta { get; set; }
    }

    public class ComprobanteDatoE { 
        public string categoria { get; set; }
        public string nombre {  get; set; }
        public bool correctivo { get; set; }
    }

    public class PepsCopVarE {
        public double DocCopagoFijoIGV { get; set; }
        public double DocCopagoVarIGV { get; set; }
        public double DocCopagoFijoEXOIGV { get; set; }
        public double DocCopagoFijoVarEXOIGV { get; set; }

        public double DocSumTotalCopago() 
        {
            return Math.Round((DocCopagoFijoIGV + DocCopagoVarIGV),2);
        }

        public double DivDocSumTotalCopago()
        {
            return Math.Round((DocSumTotalCopago() / 2),2);
        }

        public double ServSumCopagoFijo { get; set; }
        public double ServSumCopagoVariable { get; set; }
        public double FarmCopagoProducto {  get; set; }

        public double ServSumTotalCopago() 
        {
            return Math.Round((ServSumCopagoFijo + ServSumCopagoVariable + FarmCopagoProducto),2);
        }

        public double DiferenciaCopagos() 
        {
            return Math.Round((DocSumTotalCopago() - ServSumTotalCopago()), 2);
        }

        public double DiferenciaCopagoVariable()
        {
            return Math.Round((DocCopagoVarIGV - ServSumCopagoVariable - FarmCopagoProducto), 2);
        }
    }

    public class FacturaNoCuadrE 
    { 
        public double MontoTotalAtencion {  get; set; }
        
        public double SumMontoServicio {  get; set; }
        public double SumMontoNoCubiertoServicio { get; set; }

        public double DiferenciaSumaServicio()
        {
            return Math.Round((SumMontoServicio - SumMontoNoCubiertoServicio) ,2);
        }    

        public double SumMontoPorProducto { get; set; }
        public double SumMontoNoCubiertoProducto { get; set; }

        public double DiferenciaMontoProducto()
        {
            return Math.Round((SumMontoPorProducto - SumMontoNoCubiertoProducto), 2);
        }



        public double DiferenciaTotalServicio() 
        {
            return  Math.Round((MontoTotalAtencion - Math.Round((SumMontoServicio + SumMontoPorProducto),2)), 2);
        }

        public double DiferenciaTotalServicio2()
        {
            return Math.Round((MontoTotalAtencion - Math.Round((DiferenciaSumaServicio() + DiferenciaMontoProducto()) ,2)), 2);
        }
    }

    public class FacturaMontoNocuadrE { 
        public double MontoNeto { get; set; }
        public double MontoAtencion {  get; set; }
        public double CopagoFijo_SINIGV {  get; set; }
        public double CopagoFijo_EXOIGV {  get; set; }
        public double CopagoVariable_SINIGV { get; set; }
        public double CopagoVariable_EXOIGV { get; set; }

        public double DiferenciaMontoCopagos() {
            return Math.Round((MontoAtencion - CopagoFijo_SINIGV - CopagoFijo_EXOIGV - CopagoVariable_SINIGV - CopagoVariable_EXOIGV),2);
        }

        public double DiferenciaMontoTotal() {
            return Math.Round((MontoNeto - DiferenciaMontoCopagos()),2);
        }
    }

    public class DiferenciaFarmaciaE {
        public string Titulo { get; set; }
        public double SumMontoServicio { get; set; }
        public double SumCantidadXMonto { get; set; }
        public double DiferenciaFarmacia() {
            return Math.Round((SumMontoServicio - SumCantidadXMonto), 2);
        }

        public DiferenciaFarmaciaE() { }
        public DiferenciaFarmaciaE(string  _tituto,double _suma, double cantXmonto) 
        {
            SumCantidadXMonto = cantXmonto;
            SumMontoServicio = _suma;
            Titulo = _tituto;
        }
    }

    public class BCRE { 
        public double MontoServicio { get; set; }
        public double MontoCopagos {  get; set; }
        public double diferencia() 
        { 
            return Math.Round((MontoServicio - MontoCopagos), 2);
        }
    }

    public class DiferenciaCopagoE 
    {
        public double SumCopagoDocumento {  get; set; }
        public double SumCopagoAtencion { get; set; }


        public double DiferenciaMonto() 
        {
            return Math.Round((SumCopagoAtencion - SumCopagoDocumento), 2);
        }

    }

    public class DiferenciaCopagoVariableE { 
        public double SumCopagoVarServicio { get; set; }
        public double SumCopagoVarFarmacia { get; set; }
        public double SumCopagoVarAtencion { get; set; }

        public double SumCopagoSerFar() {
            return Math.Round((SumCopagoVarFarmacia + SumCopagoVarServicio), 2);
        }

        public double DifCopagoAtencionSerFar() {
            return Math.Round((SumCopagoVarAtencion - SumCopagoSerFar()), 2);
        }
    }

    public class DiferenciaMontoDocAtenE
    {
        public double MontoDocumento { get; set; }
        public double MontoAtencion { get; set; }
        public double Diferencia() 
        {
            return Math.Round((MontoDocumento - MontoAtencion), 2);
        }
    }

}
