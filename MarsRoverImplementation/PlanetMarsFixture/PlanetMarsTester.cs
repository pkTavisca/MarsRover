using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace PlanetMarsFixture
{
    [TestClass]
    public class PlanetMarsTester
    {
        [TestMethod]
        public void Retrive_length_of_planet_mars()
        {
            PlanetMars mars = new PlanetMars(5);
            Assert.IsFalse(121 == mars.Length);
            Assert.IsTrue(5 == mars.Length);
        }

        [TestMethod]
        public void Retrive_breadth_of_planet_mars()
        {
            PlanetMars mars = new PlanetMars(5);
            Assert.IsFalse(121 == mars.Breadth);
            Assert.IsTrue(10 == mars.Breadth);
        }
        [TestMethod]
        public void X_position_inside_planet_check()
        {
            PlanetMars mars = new PlanetMars();
            Assert.IsFalse(mars.IsPositionInsidePlanet(100, 0));
            Assert.IsTrue(mars.IsPositionInsidePlanet(0, 0));
        }
        [TestMethod]
        public void Y_position_inside_planet_check()
        {
            PlanetMars mars = new PlanetMars();
            Assert.IsFalse(mars.IsPositionInsidePlanet(0, 100));
            Assert.IsTrue(mars.IsPositionInsidePlanet(0, 5));
        }
    }
}
