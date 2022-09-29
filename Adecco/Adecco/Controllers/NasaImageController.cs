using System.Threading.Tasks;
using Adecco.BusinessLogic.BusinessLogic;
using Adecco.Entity.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Adecco.WebApi.Controllers
{
    /// <summary>
    /// NasaImageController 
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class NasaImageController : ControllerBase
    {
        /// <summary>
        /// IAdeccoBusinessLogic
        /// </summary>
        private IAdeccoBusinessLogic _adeccoBusinessLogic;
       
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="adeccoBusinessLogic"></param>
        public NasaImageController(IAdeccoBusinessLogic adeccoBusinessLogic)
        {
            _adeccoBusinessLogic = adeccoBusinessLogic;
        }

        /// <summary>
        /// Get images based on the filter
        /// </summary>
        /// <param name="searchInput"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<NasaImageResult>> GetNasaImagesData(string searchText,string yearEnd ,string yearStart,string mediaType)
        {
            SearchInput searchInput = new SearchInput();
            searchInput.SearchText = searchText;
            searchInput.YearStart = yearStart;
            searchInput.YearEnd = yearEnd;
            searchInput.MediaType = mediaType;
            var result = await _adeccoBusinessLogic.GetImages(searchInput);
            return Ok(result);
        }
    }
}
