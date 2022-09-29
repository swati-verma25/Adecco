
using Adecco.Entity.DTOs;
using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Adecco.Http
{
public  class NasaService
{
    private readonly HttpClient _httpClient;

    public NasaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://images-api.nasa.gov/");

        _httpClient.DefaultRequestHeaders.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");


    }

     private string GetParams(SearchInput searchInput) {


            var param = new Dictionary<string, string>() { { "q", searchInput.SearchText } };
            if (!string.IsNullOrWhiteSpace(searchInput.YearEnd))
            {
                param.Add("year_end", searchInput.YearEnd);

            }
            if (!string.IsNullOrWhiteSpace(searchInput.YearStart))
            {
                param.Add("year_start", searchInput.YearStart);

            }
            if (!string.IsNullOrWhiteSpace(searchInput.MediaType))
            {
                param.Add("media_type", searchInput.MediaType);

            }
            string paramsData = new FormUrlEncodedContent(param).ReadAsStringAsync().Result;
            return paramsData;
         } 

     public async Task<NasaImageResult> GetNasaImagesAsync(SearchInput searchInput){

            NasaImageResult resultData = null;
          
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };

                var urlWithParams = GetParams(searchInput);
                var result = await _httpClient.GetAsync("search?"+urlWithParams);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var contentData = result.Content.ReadAsStringAsync().Result;

                    resultData = JsonSerializer.Deserialize<NasaImageResult>(contentData, options);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
       
            return resultData;
    }
}

}
