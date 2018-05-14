namespace supportDesk.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class SL_SolicitudCredito
    {
        [StringLength(1)]
        public string Seguro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grupo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SolicCabecera { get; set; }

        [StringLength(1)]
        public string ModoCobroCargos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IndScoring { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RiesgoGlobal { get; set; }

        [StringLength(1)]
        public string C2320 { get; set; }

        [StringLength(4)]
        public string CodCanal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Familia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrigenLlegada { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MedioOrigen { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CodNegocio { get; set; }

        [StringLength(1)]
        public string Estrategia { get; set; }

        [StringLength(8)]
        public string CodActContr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CodActCiiu { get; set; }

        [StringLength(8)]
        public string ActEconInterna { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PlazoDisp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PagoMinimo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MontoCondonacion { get; set; }

        [StringLength(1)]
        public string Procesado { get; set; }

        [StringLength(1)]
        public string Modalidad_Cobro_Cuota { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal C5000 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5001 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5002 { get; set; }

        [StringLength(8)]
        public string C5003 { get; set; }

        [StringLength(20)]
        public string C5004 { get; set; }

        public DateTime? C5006 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5008 { get; set; }

        [StringLength(5)]
        public string C5009 { get; set; }

        [StringLength(600)]
        public string C5022 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5023 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5024 { get; set; }

        public DateTime? C5025 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5026 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5028 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5029 { get; set; }

        [StringLength(4)]
        public string C5030 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5031 { get; set; }

        [StringLength(60)]
        public string C5033 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5034 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5035 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5036 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5037 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5038 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5039 { get; set; }

        [StringLength(1)]
        public string C5040 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5041 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5042 { get; set; }

        [StringLength(50)]
        public string C5043 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5044 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5045 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pizarra { get; set; }

        public DateTime? FCreac1erEt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5049 { get; set; }

        [StringLength(1)]
        public string C5050 { get; set; }

        public DateTime? C5053 { get; set; }

        public DateTime? C5054 { get; set; }

        [StringLength(1)]
        public string ImpCartaDesmb { get; set; }

        [StringLength(8)]
        public string C5059 { get; set; }

        public DateTime? C5060 { get; set; }

        [StringLength(8)]
        public string C5061 { get; set; }

        public DateTime? C5062 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5063 { get; set; }

        [StringLength(8)]
        public string C5064 { get; set; }

        [StringLength(1)]
        public string Revolvente { get; set; }

        [StringLength(1)]
        public string TipoRevolvente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ModDisp { get; set; }

        [StringLength(8)]
        public string C5070 { get; set; }

        [StringLength(1)]
        public string TipSol { get; set; }

        [StringLength(1)]
        public string C5074 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NroLin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CodColectivo { get; set; }

        public DateTime? C5183 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5186 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5187 { get; set; }

        public DateTime? C5190 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5221 { get; set; }

        [StringLength(8)]
        public string C5222 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5223 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5225 { get; set; }

        public DateTime? C5226 { get; set; }

        [StringLength(8)]
        public string C5227 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Dia_Pago { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5229 { get; set; }

        [StringLength(2)]
        public string C5230 { get; set; }

        public DateTime? C5231 { get; set; }

        [StringLength(1)]
        public string TipoCalificac { get; set; }

        [StringLength(1)]
        public string C5233 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Monto_Flat { get; set; }

        [StringLength(8)]
        public string C5261 { get; set; }

        [StringLength(2)]
        public string FormaDesembolso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OID_Desembolso_Cuenta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Porcentaje_Flat { get; set; }

        [StringLength(1)]
        public string C5270 { get; set; }

        [StringLength(20)]
        public string C5271 { get; set; }

        [StringLength(60)]
        public string C5272 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5273 { get; set; }

        [StringLength(60)]
        public string C5274 { get; set; }

        [StringLength(60)]
        public string C5275 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Valor_Seguro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5280 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C5281 { get; set; }

        [StringLength(4)]
        public string C5283 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Moneda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CodBancoDesembolso { get; set; }

        [StringLength(50)]
        public string SucBancoDesembolso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LineaFinanc { get; set; }

        [StringLength(250)]
        public string ModalidadDesembolso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IdConvenio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpcionesRefinanciacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JtsOidCta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Beneficiario { get; set; }

        [StringLength(1)]
        public string DestinoCartaF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NroCartaFianza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CtaOrigen { get; set; }

        [StringLength(1)]
        public string RenovPrest { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NroCartaOri { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NroCartaAnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OID_Cobro_Cuota { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AdicionalRefinanciado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Deuda_Solicitud { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Deuda_Actual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NroActa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Monto_ITF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TCambio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LugarDesemb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UsuDesemb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NroOperacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C6945 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CodCargo { get; set; }

        [StringLength(2)]
        public string Tipo_Credito { get; set; }

        [StringLength(1)]
        public string DesembParciales { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IdMetodologia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PorcentajeITF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C2841 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TZ_LOCK { get; set; }

        [Required]
        [StringLength(1)]
        public string Desembolso_Online { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaskId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Token { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TIPO_PRESTAMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RUBRO_CHEQUE { get; set; }

        [StringLength(1)]
        public string ABONADO { get; set; }

        [StringLength(1)]
        public string ORIGEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TCEA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RECHAZOS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TRANS_Cta_Credi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TRANS_Moneda_Credi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SUCURSAL_BANCO_BN { get; set; }

        public SL_SolicitudCredito Obtener (long idSolicitud)
        {
            var dataSolicitud = new SL_SolicitudCredito();
            try
            {
                using (var ctx = new ceContext())
                {
                    dataSolicitud = ctx.SL_SolicitudCredito.Where(x => x.C5000 == idSolicitud)
                                                            .SingleOrDefault();

                }

            }catch (Exception)
            {
                throw;
            }
            return dataSolicitud;
        }


    }
}
