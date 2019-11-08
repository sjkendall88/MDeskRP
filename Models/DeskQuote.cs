using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDeskRP.Models
{
    public class DeskQuote
    {
        /// <summary>
        /// Parameter free Constructor
        /// </summary>
        /// <remarks>
        /// Required for scaffolding the UI
        /// </remarks>
        public DeskQuote() { }

        /// <summary>
        /// DeskQuote ID
        /// </summary>
        public int DeskQuoteID { get; set; }

        /// <summary>
        /// Customer ID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Customer information
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Desk Specifications
        /// </summary>
        public int DeskSpecsID { get; set; }

        /// <summary>
        /// Desk Specifications
        /// </summary>
        public DeskSpecs DeskSpecs { get; set; }

    }
}
