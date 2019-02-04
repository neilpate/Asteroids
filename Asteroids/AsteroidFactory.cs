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

            var initialPosition = new Point(rnd.Next(maxX), rnd.Next(maxY));

            var initialVelocity = new Vector2(rnd.Next(10)-5, rnd.Next(10)-5);

            var initialAngle = (double)(rnd.Next(360)-180);


            string name = "";

            var asteroid = new Asteroid(name, initialPosition, initialVelocity, initialAngle, Mass );
            return asteroid;
        }

    }
}
