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
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DRAWER = 0;
        public const int MAX_DRAWER = 7;
        /// <summary>
        /// desk width
        /// </summary>
        public int DeskSpecsID { get; set; }

        /// <summary>
        /// desk width
        /// </summary>
        [Required]
        [Range(MIN_WIDTH, MAX_WIDTH, ErrorMessage = "Width must be 24-96 inches")]
        public string Width { get; set; }

        /// <summary>
        /// desk depth
        /// </summary>
        [Required]
        [Range(MIN_DEPTH, MAX_DEPTH, ErrorMessage = "Depth must be 12-48 inches")]
        public string Depth { get; set; }

        /// <summary>
        /// number of desk drawers
        /// </summary>
        [Required]
        [Range(MIN_DRAWER, MAX_DRAWER, ErrorMessage = "Number of drawers must be 0-7")]
        [Display(Name = "Number of drawers")]
        public string NumOfDrawers { get; set; }

        /// <summary>
        /// type of desktop material
        /// </summary>
        [DefaultValue(DeskTypeEnum.Laminate)]
        [Display(Name = "Desktop material")]
        public DeskTypeEnum DeskTypeString { get; set; }

        /// <summary>
        /// type of desktop material Description
        /// </summary>
        public DeskTypeDescription DeskTypeDescription { get; set; }

        /// <summary>
        /// number of rushed days
        /// </summary>
        [Required]
        //[Range((3,5,7), ErrorMessage = "Rush order options are 3, 5 or 7 days")]
        [RegularExpression(@"^[3,5,7,14]*$")]
        [Display(Name = "Rush days")]
        public string RushDays { get; set; }

        /// <summary>
        /// List of Desks
        /// </summary>
        public List<DeskQuote> DeskQuotes { get; set; }
    }
}
