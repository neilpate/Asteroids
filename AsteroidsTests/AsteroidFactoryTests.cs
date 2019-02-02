using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asteroids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Tests
{
    [TestClass()]
    public class AsteroidFactoryTests
    {
        [TestMethod()]
        public void CreateAsteroidTest()
        {
            var asteroidFactory = new AsteroidFactory();
            var asteroid = asteroidFactory.CreateAsteroid(100, 100);

            string expectedName = "first";

            Assert.AreEqual(expectedName, asteroid.Name);


        }
    }
}