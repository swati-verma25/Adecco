using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Adecco.BusinessLogic.BusinessLogic;
using Adecco.Repository.Entities;
using Adecco.Repository.Repositories;

namespace Adecco.Businesslogic.Test.Businesslogic
{
    [TestClass]
    public class AdeccoBusinessLogicTest
    {
        [TestMethod]
        public void Test_GetProducts()
         {
        //     AdeccoBusinessLogic bl = MockTarrifBL();
        //     var actionResult = bl.GetImages(700);
        //     Assert.IsNotNull(actionResult);
        //     var arrayObj = actionResult.ToArray();
        //     Assert.AreEqual(2, arrayObj.Count());
        }


        // private AdeccoBusinessLogic MockTarrifBL()
        // {
        //     var mockTariffBL = new Mock<IAdeccoRepository>();
        //     mockTariffBL.Setup(repo => repo.GetAllImages()).Returns(null);

        //     return new AdeccoBusinessLogic(mockTariffBL.Object);
        // }
        }
    
}
