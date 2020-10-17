using GHActTest2.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace TestsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            Assert.Pass();

        }



        [Test]
        public void IndexViewDataMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Hello1!", result?.ViewData["Message"]);
        }



        [Test]
        public void IndexViewResultNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Test]
        public void IndexViewNameEqualIndex()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.AreEqual("Index", result?.ViewName);
        }




    }
}