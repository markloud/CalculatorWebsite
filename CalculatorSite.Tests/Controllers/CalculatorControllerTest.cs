using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorSite.Controllers;

namespace CalculatorSite.Tests.Controllers
{
    [TestClass]
    public class CalculatorControllerTest
    {
        CalculatorController controller = new CalculatorController();

        [TestMethod]
        public void Add()
        {
            // Arrange

            // Act
            decimal result = controller.Add(1.1m, 2.2m);

            // Assert
            Assert.AreEqual(result, 3.3m);

            // Cleanup
        }

        [TestMethod]
        public void Subtract()
        {
            // Arrange

            // Act
            decimal result = controller.Subtract(1.1m, 2.2m);

            // Assert
            Assert.AreEqual(result, -1.1m);

            // Cleanup
        }

        [TestMethod]
        public void Multiply()
        {
            // Arrange

            // Act
            decimal result = controller.Multiply(1.1m, 2.2m);

            // Assert
            Assert.AreEqual(result, 2.42m);

            // Cleanup
        }

        [TestMethod]
        public void Divide()
        {
            // Arrange

            // Act
            //decimal result = controller.Divide(2.2m, 1.1m);
            decimal result = controller.Divide(0m, 1.1m);

            // Assert
            Assert.AreEqual(result, 0);

            // Cleanup
        }
    }
}
