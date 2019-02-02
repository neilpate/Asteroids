using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SDL2;


namespace Asteroids
{
    class World
    {
        readonly Renderer renderer;

        private const int NumberOfAsteroids = 100;
        List<Asteroid> asteroids = new List<Asteroid>();
        AsteroidFactory asteroidFactory = new AsteroidFactory();
     


        public World(Renderer renderer)
        {
            this.renderer = renderer;

            PopulateWorld();

           
        }

        private void PopulateWorld()
        {

            for (int i = 0; i < NumberOfAsteroids; i++)
            {
                var asteroid = asteroidFactory.CreateAsteroid(640, 480);
                asteroids.Add(asteroid);
            }

        }

        public void Update(long elapsedMilliseconds)
        {
            SDL.SDL_SetRenderDrawColor(renderer.renderer, 0x00, 0x00, 0x00, 0xFF);

            SDL.SDL_RenderClear(renderer.renderer);

            foreach (var asteroid  in asteroids)
            {
                asteroid.Update(elapsedMilliseconds);
                asteroid.Draw(renderer);

            }

            SDL.SDL_RenderPresent(renderer.renderer);


        }



    }
}
