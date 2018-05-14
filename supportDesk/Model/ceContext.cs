namespace supportDesk.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ceContext : DbContext
    {
        public ceContext()
            : base("name=ceContext")
        {
        }

        public virtual DbSet<SL_SolicitudCredito> SL_SolicitudCredito { get; set; }
        public virtual DbSet<tbl_logEstado> tbl_logEstado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Seguro)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Grupo)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.SolicCabecera)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.ModoCobroCargos)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.IndScoring)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.RiesgoGlobal)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C2320)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CodCanal)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Familia)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.OrigenLlegada)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.MedioOrigen)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CodNegocio)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Estrategia)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CodActContr)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CodActCiiu)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.ActEconInterna)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.PlazoDisp)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.PagoMinimo)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.MontoCondonacion)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Procesado)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Modalidad_Cobro_Cuota)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5000)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5001)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5002)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5003)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5004)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5008)
                .HasPrecision(11, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5009)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5022)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5023)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5024)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5026)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5028)
                .HasPrecision(3, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5029)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5030)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5031)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5033)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5034)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5035)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5036)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5037)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5038)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5039)
                .HasPrecision(11, 7);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5040)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5041)
                .HasPrecision(11, 7);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5042)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5043)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5044)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5045)
                .HasPrecision(6, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Pizarra)
                .HasPrecision(6, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5049)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5050)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.ImpCartaDesmb)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5059)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5061)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5063)
                .HasPrecision(3, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5064)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Revolvente)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TipoRevolvente)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.ModDisp)
                .HasPrecision(1, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5070)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TipSol)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5074)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.NroLin)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CodColectivo)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5186)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5187)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5221)
                .HasPrecision(6, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5222)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5223)
                .HasPrecision(6, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5225)
                .HasPrecision(11, 7);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5227)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Dia_Pago)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5229)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5230)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TipoCalificac)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5233)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Monto_Flat)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5261)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.FormaDesembolso)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.OID_Desembolso_Cuenta)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Porcentaje_Flat)
                .HasPrecision(3, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5270)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5271)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5272)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5273)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5274)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5275)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Valor_Seguro)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5280)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5281)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C5283)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Moneda)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CodBancoDesembolso)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.SucBancoDesembolso)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.LineaFinanc)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.ModalidadDesembolso)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.IdConvenio)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.OpcionesRefinanciacion)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.JtsOidCta)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Beneficiario)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.DestinoCartaF)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.NroCartaFianza)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CtaOrigen)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.RenovPrest)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.NroCartaOri)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.NroCartaAnt)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.OID_Cobro_Cuota)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.AdicionalRefinanciado)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Deuda_Solicitud)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Deuda_Actual)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.NroActa)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Monto_ITF)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TCambio)
                .HasPrecision(11, 7);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.LugarDesemb)
                .HasPrecision(3, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.UsuDesemb)
                .HasPrecision(5, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.NroOperacion)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C6945)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.CodCargo)
                .HasPrecision(3, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Tipo_Credito)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.DesembParciales)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.IdMetodologia)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.PorcentajeITF)
                .HasPrecision(11, 10);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.C2841)
                .HasPrecision(11, 7);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TZ_LOCK)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Desembolso_Online)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TaskId)
                .HasPrecision(19, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.Token)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TIPO_PRESTAMO)
                .HasPrecision(1, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.RUBRO_CHEQUE)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.ABONADO)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.ORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TCEA)
                .HasPrecision(11, 7);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.RECHAZOS)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TRANS_Cta_Credi)
                .HasPrecision(15, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.TRANS_Moneda_Credi)
                .HasPrecision(4, 0);

            modelBuilder.Entity<SL_SolicitudCredito>()
                .Property(e => e.SUCURSAL_BANCO_BN)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tbl_logEstado>()
                .Property(e => e.Objeto)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_logEstado>()
                .Property(e => e.MotivoCambio)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_logEstado>()
                .Property(e => e.Parametro)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_logEstado>()
                .Property(e => e.Usuario)
                .IsUnicode(false);
        }
    }
}
