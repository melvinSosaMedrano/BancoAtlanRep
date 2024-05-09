using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanApi.Models
{
    public class TBL_CNTTARJETA
    {
        /// <summary>
        /// TABLA DE UNION DE CUENTAS CON TARJETAS
        /// </summary>
        public int CODAGENCIA { get; set; }
        public int NUMCUENTA { get; set; }
        public int NUMTARJETA { get; set; }
    }
}
