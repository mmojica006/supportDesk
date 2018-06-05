using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supportDesk.Model.Procedure
{
    public class usp_solicitud
    {
        public decimal idsolicitud { get; set; }
        public string estado { get; set; }
        public string nombre { get; set; }
        public string tipoCredito { get; set; }
        public string estadoWF { get; set; }


    }
}
