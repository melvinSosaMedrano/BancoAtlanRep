using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanProject.Models
{
    public class TBL_CUENTASDET
    {
        /// <summary>
        /// TABLA DE DETALLE DE LAS CUENTAS
        /// </summary>
        public int CODAGENCIA { get; set; }
        public int NUMCUENTA { get; set; }
        public int CODDETALLECUENTA { get; set; }
        public decimal SALDOGLOBALDISPO { get; set; }
        public decimal INTERESCONF { get; set; }
        public decimal INTERESCONFCUOMIN { get; set; }
        public decimal INTERESCONFBONIF  { get; set; }
        public decimal SALDOGLOBAL { get; set; }
        public decimal LIMITEMAXACTUAL { get; set; }
        public decimal PAGOMINIMO { get; set; }
    }
}
