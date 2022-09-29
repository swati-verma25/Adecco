using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Adecco.BusinessLogic.BusinessLogic;
using Adecco.Entity.DTOs;
using Adecco.Http;
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
        [HttpPost]
        public ActionResult<IEnumerable<NasaImageResult>> GetNasaImages([FromBody]SearchInput searchInput)
        {
            var result = _adeccoBusinessLogic.GetImages(searchInput);
            return Ok(result?.ToArray());
            
        }
    }
}
