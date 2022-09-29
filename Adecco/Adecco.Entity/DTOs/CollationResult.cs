using System.Collections.Generic;

namespace Adecco.Entity.DTOs{

public class CollationResult
{
    public string Version {get;set;}
    public string Href {get;set;}
    public List<ItemResult> Items { get; set; }

    }
}