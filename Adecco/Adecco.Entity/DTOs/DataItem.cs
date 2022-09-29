using System;
using System.Collections.Generic;
namespace Adecco.Entity.DTOs{

public class DataItem
{ 
    public List<string> Album {get;set;}
    public string Center {get;set;}
    public string Title {get;set;}
    public string Photographer {get;set;}
    public string location {get;set;}
    public string nasa_id {get;set;}
    public string media_type {get;set;}
    public List<string> keywords {get;set;}
    public DateTime date_created {get;set;}
    public string description {get;set;}
   
}
}