using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supportDesk.Model.Procedure
{
    public class uspe_sd_rpt_fecha
    {
        public int id { get; set; }
        public string objeto { get; set; }
        public string motivoCambio { get; set; }
        public long Solicitud { get; set; }
        public string EstadoAnterior { get; set; }
        public string NuevoEstado { get; set; }
        public string Usuario { get; set; }
        public DateTime fecha { get; set; }

    }
}
