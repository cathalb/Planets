using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetsDatabase.Api.Controllers;

namespace PlanetsDatabase.Api.Tests
{
    [TestClass]
    public class PlanetServiceTests
    {
        [TestMethod]
        public void GettingAllPlanets_SholudReturnAllPlanets()
        {
            var controller = new PlanetsController();

            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }
}