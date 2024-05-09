using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanApi.Models
{
    public class TBL_CUENTAS
    {

        /// <summary>
        /// TABLA DE CUENTAS CON CLIENTES
        /// </summary>
        public int CODAGENCIA { get; set; }
        public int CODCLIENTE { get; set; }
        public int NUMCUENTA { get; set; }
        public int CODTIPOCUENTA { get; set; }
    }
}
