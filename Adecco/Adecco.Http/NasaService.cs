
using Adecco.Entity.DTOs;

using System.Collections.Generic;
using System.Linq;
//using Newtonsoft.Json;
using System;
using System.Net.Http;
//using System.Net.Http.Formatting;
using System.Threading.Tasks;
 
namespace Adecco.Http
{
public  class NasaService
{
    private readonly HttpClient _httpClient;

    public NasaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://images-api.nasa.gov/");

        // using Microsoft.Net.Http.Headers;
        // The GitHub API requires two headers.
        _httpClient.DefaultRequestHeaders.Add(
            "Accept", "application/vnd.github.v3+json");
       
    }

    public async Task<IEnumerable<NasaImageResult>> GetNasaImagesAsync(SearchInput searchInput){
        return null; //  _httpClient.Content<IEnumerable<TariffDTO>>(
           // "/search");
    }
}

}
