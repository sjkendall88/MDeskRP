﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MDeskRP.Models
{
    public class DeskTypeDescription
    {
        /// <summary>
        /// desk width
        /// </summary>
        [Key]
        public DeskTypeEnum DeskTypeString { get; set; } // ie projectstatecode

        /// <summary>
        /// desk width
        /// </summary>
        public string DeskType { get; set; } // ie statedescription

        /// <summary>
        /// desk width
        /// </summary>
        public IEnumerable<DeskSpecs> DeskQuote { get; set; } // ie Project/project
    }
}
