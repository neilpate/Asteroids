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
    public class UtilityTests
    {
        [TestMethod()]
        public void DegreesToRadiansTest()
        {
            var degrees = 90.0f;
            var expected = 1.5708;
            var actual = Utility.DegreesToRadians(degrees);

            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}