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
    /// <summary>
    /// Pruebas unitarias del controlador Login
    /// </summary>
    [TestClass]
    public class LoginControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            LoginController controller = new LoginController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
