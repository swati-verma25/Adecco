using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Adecco.BusinessLogic.BusinessLogic;
using Adecco.Entity.DTOs;

namespace Adecco.WebApi.Controllers.Tests
{
    [TestClass]
    public class TariffsControllerTest
    {
        // [TestMethod]
        // public void GetTariffsByAnnualConsumption_ReturnsOk()
        // {
        //     NasaImageController controller = MockTarrifController();
        //     ActionResult<IEnumerable<TariffDTO>> actionResult = controller.GetTarriffByConsumption(annualConsumption: 700);
        //     Assert.IsNotNull(actionResult);
        // }

        // [TestMethod]
        // public void GetTariffsByAnnualConsumption_ReturnsBadRequest()
        // {
        //     NasaImageController controller = MockTarrifController();
        //     ActionResult<IEnumerable<TariffDTO>> actionResult = controller.GetTarriffByConsumption(annualConsumption: -700);

        //     Assert.IsInstanceOfType(actionResult.Result, typeof(BadRequestObjectResult));
        // }

        // [TestMethod]
        // public void GetTariffsByAnnualConsumption_Given4500KWh_ReturnsTariffDTOs()
        // {
        //     NasaImageController controller = MockTarrifController();
        //     ActionResult<IEnumerable<TariffDTO>> actionResult = controller.GetTarriffByConsumption(annualConsumption: 4500);
        //     Assert.IsInstanceOfType(actionResult.Result, typeof(ObjectResult));

        //     Assert.IsNotNull(actionResult);
        // }

        // private NasaImageController MockTarrifController()
        // {
        //     var mockTariffBL = new Mock<IAdeccoBusinessLogic>();
        //     mockTariffBL.Setup(repo => repo.GetImages(300)).Returns(null);

        //     return new NasaImageController(mockTariffBL.Object);
        // }

        // private IEnumerable<TariffDTO> CreateTariffs()
        // {
        //     List<TariffDTO> list = new List<TariffDTO>();
        //     list.Add(new TariffDTO { AnnualCosts = 500, Name = "Test 1" });
        //     list.Add(new TariffDTO { AnnualCosts = 1500, Name = "Test 2" });
        //     return list;
        // }
    }
}
