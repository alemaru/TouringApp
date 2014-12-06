using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using TouringApp;
using TouringApp.Controllers;
using TouringApp.Models.TO;

namespace TouringApp.Tests.Controllers
{
    [TestClass]
    public class CartillaControllerTest
    {
        [TestMethod]
        public void CartillaIndex()
        {
            // Arrange
            CartillaController controller = new CartillaController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
