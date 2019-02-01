using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class World
    {
        private const int NumberOfAsteroids = 10;

        List<Asteroid> asteroids = new List<Asteroid>();

        public World()
        {
            var asteroidFactory = new AsteroidFactory();


            for (int i = 0; i < NumberOfAsteroids; i++)
            {
                var asteroid = asteroidFactory.CreateAsteroid(100,100);
                asteroids.Add(asteroid);
            }
        }

    }
}
