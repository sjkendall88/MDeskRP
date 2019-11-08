using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDeskRP.Models
{
    public class DeskTypeDescription
    {
        /// <summary>
        /// desk width
        /// </summary>
        public DeskTypeEnum DeskTypeString { get; set; }

        /// <summary>
        /// desk width
        /// </summary>
        public string DeskType { get; set; }

        /// <summary>
        /// desk width
        /// </summary>
        public IEnumerable<DeskSpecs> DeskQuote { get; set; }
    }
}
