using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanProject.Models
{
    public class TBL_HISTRANSAC
    {
        /// <summary>
        /// TABLA DE HISTORICO DE TRANSACCIONES
        /// </summary>
        public int CODAGENCIA { get; set; }
        public int TRANSACNUM { get; set; }
        public int NUMCUENTA { get; set; }
        public decimal MONTO { get; set; }
        public string DESCRIPCION { get; set; }
        public DateTime FECHATRANSAC { get; set; }
        public int CREDDEB { get; set; }
    }
}
