using System;
using System.Collections.Generic;

namespace Adecco.Entity.DTOs{

public class ItemResult
{
        /// <summary>
        /// name of the product
        /// </summary>
        public string href { get; set; }

        public List<DataItem> Data {get;set;}

        public List<LinkItem> links  { get; set; }
}
}
