using System.Threading.Tasks;
using Adecco.BusinessLogic.BusinessLogic;
using Adecco.Entity.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Adecco.WebApi.Controllers.Tests
{
    [TestClass]
    public class NasaImageControllerTest
    {
         [TestMethod]
         public void GetList_ReturnsOk()
         {
             NasaImageController controller = NasaImageController();
            Task<ActionResult<NasaImageResult>> actionResult = controller.GetNasaImagesData("","","","");
            Assert.IsNotNull(actionResult);
        }


         private NasaImageController NasaImageController()
         {
            SearchInput input = new SearchInput();
             var mockTariffBL = new Mock<IAdeccoBusinessLogic>();
            NasaImageResult result = new NasaImageResult();
            mockTariffBL.Setup(repo => repo.GetImages(input)).Returns(Task.FromResult(result));

            return new NasaImageController(mockTariffBL.Object);
        }

    }
}
