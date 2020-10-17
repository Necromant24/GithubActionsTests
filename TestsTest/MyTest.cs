using GHActTest2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestsTest
{
    public class MyTest
    {


        [Fact]
        public void IndexViewDataMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            NUnit.Framework.Assert.AreEqual("Hello!", result?.ViewData["Message"]);
        }



        [Fact]
        public void IndexViewResultNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            NUnit.Framework.Assert.NotNull(result);
        }

        [Fact]
        public void IndexViewNameEqualIndex()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            NUnit.Framework.Assert.AreEqual("Index", result?.ViewName);
        }



    }
}
