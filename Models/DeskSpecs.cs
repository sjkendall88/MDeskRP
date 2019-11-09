using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDeskRP.Models
{
    public class DeskSpecs
    {
        /// <summary>
        /// desk width
        /// </summary>
        public int DeskSpecsID { get; set; }

        /// <summary>
        /// desk width
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// desk depth
        /// </summary>
        public string Depth { get; set; }

        /// <summary>
        /// number of desk drawers
        /// </summary>
        public string NumOfDrawers { get; set; }

        /// <summary>
        /// type of desktop material
        /// </summary>
        [DefaultValue(DeskTypeEnum.Laminate)]
        public DeskTypeEnum DeskTypeString { get; set; }

        /// <summary>
        /// type of desktop material Description
        /// </summary>
        public DeskTypeDescription DeskTypeDescription { get; set; }

        /// <summary>
        /// number of rushed days
        /// </summary>
        public string RushDays { get; set; }

        /// <summary>
        /// List of Desks
        /// </summary>
        public List<DeskQuote> DeskQuotes { get; set; }
    }
}
