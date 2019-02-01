using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;


namespace Asteroids
{
    public class AsteroidFactory
    {
        const double Mass = 1000;
        private Random rnd = new Random();

        public Asteroid CreateAsteroid(int maxX, int maxY)
        {

            var position = new Point(rnd.Next(maxX), rnd.Next(maxY));

            var velocity = new Vector2(rnd.Next(10), rnd.Next(10));

            string name = "first";

            var asteroid = new Asteroid(name, position, velocity, Mass );
            return asteroid;
        }

    }
}
