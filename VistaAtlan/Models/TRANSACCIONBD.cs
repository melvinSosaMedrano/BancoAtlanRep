using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaAtlan.Models
{
    public class TRANSACCIONBD
    {
        public int NUMTARJETA { get; set; }
        public decimal MONTO { get; set; }
        public string DESCRIPCION { get; set; }
        public int TIPO { get; set; }
    }
}
