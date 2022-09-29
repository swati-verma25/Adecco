
using System.Collections.Generic;
using Adecco.Entity.DTOs;
using System.Threading;
using System;
using System.Threading.Tasks;
namespace Adecco.BusinessLogic.BusinessLogic
{
    /// <summary>
    /// IAdeccoBusinessLogic
    /// </summary>
    public interface IAdeccoBusinessLogic
    {
        /// <summary>
        /// Get images from Service
        /// </summary>
        /// <param name="searchInput"></param>
        /// <returns></returns>
        IEnumerable<NasaImageResult> GetImages(SearchInput searchInput);
    }
}
