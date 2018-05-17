namespace supportDesk.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("tbl_logEstado")]
    public partial class tbl_logEstado
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string Objeto { get; set; }

        [Required]
        [StringLength(255)]
        public string MotivoCambio { get; set; }

        [Required]
        [StringLength(100)]
        public string Parametro { get; set; }

        public long solicitud { get; set; }

        [Required]
        [StringLength(100)]
        public string EstadoAnterior { get; set; }

        [Required]
        [StringLength(100)]
        public string NuevoEstado { get; set; }

        [Required]
        [StringLength(100)]
        public string Usuario { get; set; }

        public DateTime? fecha { get; set; }


        public List<tbl_logEstado> Listar()
        {
            var tbl_logEstado = new List<tbl_logEstado>();
            try
            {
                using (var ctx = new ceContext())
                {
                    tbl_logEstado = ctx.tbl_logEstado.ToList();
                }



            }catch(Exception)
            {
                throw;

            }

            return tbl_logEstado;


        }


        public void Guardar(tbl_logEstado data)
        {

           try
            {

                using (var ctx = new ceContext())
                {
                    //Existe
                    ctx.Configuration.AutoDetectChangesEnabled = false;
                    ctx.Configuration.ValidateOnSaveEnabled = false;

                    
                    if (data.id > 0)
                    {
                        ctx.Entry(data).State = EntityState.Modified;

                    }else //nuevo registro
                    {
                        var logData = ctx.Entry(data);
                        logData.State = EntityState.Added;
                        // ctx.Entry(data).State = EntityState.Added;
                        logData.Property(x => x.fecha).IsModified = false;

                    }

                   

                    ctx.SaveChanges();

                }


            }
            catch(Exception e)
            {
                throw;
            }

            

        }

        public void Eliminar (int id)
        {
            try
            {
                using (var ctx = new ceContext())
                {
                    ctx.Entry(new tbl_logEstado { id = id }).State = EntityState.Deleted;
                    ctx.SaveChanges();

                }


            }
            catch (Exception)
            {
                throw;
            }

            


        }


        public tbl_logEstado Obtener(int id)
        {
            var tblData = new tbl_logEstado();

            try
            {

                using (var ctx = new ceContext())
                {
                    tblData = ctx.tbl_logEstado.Where(x => x.id==id)
                                               .SingleOrDefault();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return tblData;



        }
    }
}
