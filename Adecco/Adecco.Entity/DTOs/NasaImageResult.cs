using System;
using System.Collections.Generic;

namespace Adecco.Entity.DTOs
{
public class NasaImageResult
{
    /// <summary>
        /// name of the product
        /// </summary>
        public CollationResult collation { get; set; }

        public List<ItemResult> items {get;set;} 
}
}