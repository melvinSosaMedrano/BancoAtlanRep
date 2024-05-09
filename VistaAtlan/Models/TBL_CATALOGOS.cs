using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanProject.Models
{
    public class TBL_CATALOGOS
    {
        /// <summary>
        /// TABLA DE CATALOGOS VARIOS
        /// </summary>
        public int CODAGENCIA { get; set; }
        public int CODCATALOGO { get; set; }
        public string TEXT { get; set; }
        public string VALUE { get; set; }
        public string TITTLE { get; set; }
        public string MANTTO { get; set; }

    }
}
