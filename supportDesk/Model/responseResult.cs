using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supportDesk.Model
{
    public class responseResult
    {
        public bool Success { get; set; }
        public string mensaje { get; set; }
        public string ErrorMessage { get; set; }
    }
}
