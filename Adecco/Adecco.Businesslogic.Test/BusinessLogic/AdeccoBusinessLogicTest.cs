using System.Threading.Tasks;
using Adecco.BusinessLogic.BusinessLogic;
using Adecco.Http;
using Adecco.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Adecco.Businesslogic.Test.Businesslogic
{
    [TestClass]
    public class AdeccoBusinessLogicTest
    {
        [TestMethod]
        public void Test_GetProducts()
         {
             AdeccoBusinessLogic bl = MockBL();
             var actionResult = bl.GetImages(new Entity.DTOs.SearchInput());
             Assert.IsNotNull(actionResult);
       
        }


         private AdeccoBusinessLogic MockBL()
         {
            var mockTariffBL = new Mock<IAdeccoRepository>();
             mockTariffBL.Setup(repo => repo.GetAllImages()).Returns(null);


            var mockNasaService = new Mock<NasaService>();
            mockNasaService.Setup(repo => repo.GetNasaImagesAsync(new Entity.DTOs.SearchInput()))
                .Returns(Task.FromResult(new Entity.DTOs.NasaImageResult()));

            return new AdeccoBusinessLogic(mockTariffBL.Object, mockNasaService.Object);
         }
        }
    
}
