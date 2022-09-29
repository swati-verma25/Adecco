using System.Collections.Generic;
using System.Linq;
using Adecco.Repository.Repositories;
using Adecco.Entity.DTOs;
using Adecco.Http;
using System.Threading;
namespace Adecco.BusinessLogic.BusinessLogic
{
    /// <summary>
    /// TariffBusinessLogic
    /// </summary>
    public class AdeccoBusinessLogic : IAdeccoBusinessLogic
    {
        private IAdeccoRepository _adeccoRepository;
        private readonly NasaService _nasaService;

        public AdeccoBusinessLogic(IAdeccoRepository adeccoRepository,NasaService nasaService)
        {
            _adeccoRepository = adeccoRepository;
            _nasaService=nasaService;
        }

        /// <summary>
        /// Getting product data from service
        /// </summary>
        /// <param name="searchInput"></param>
        /// <returns></returns>
        public IEnumerable<NasaImageResult> GetImages(SearchInput searchInput)
        { 
            List<NasaImageResult> doctors = new List<NasaImageResult>
            {
                new NasaImageResult()
            };
            return doctors;// Task.FromResult(doctors);
          //  return  await _nasaService.GetNasaImagesAsync();
           //  return null ;
        }
    }
}
