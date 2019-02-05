using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SDL2;
using System.Drawing;


namespace Asteroids
{
    /// <summary>
    /// Responsible for managing all the "physical" objects that in the game world 
    /// </summary>
    class World
    {
        const int SizeX = 640;
        const int SizeY = 480;

        readonly Renderer renderer; //created in Game and passed in when the World is created

        private const int NumberOfAsteroids = 5;
        List<Asteroid> asteroids = new List<Asteroid>();
        AsteroidFactory asteroidFactory = new AsteroidFactory();

        Player player;

        public World(Renderer renderer)
        {
            this.renderer = renderer;

            PopulateWorld();

           
        }

        /// <summary>
        /// Creates all the actors that appear in the world
        /// </summary>
        private void PopulateWorld()
        {

            for (int i = 0; i < NumberOfAsteroids; i++)
            {
                var asteroid = asteroidFactory.CreateAsteroid(SizeX, SizeY);
                asteroids.Add(asteroid);
            }

            player = new Player("Player 1");

        }

        /// <summary>
        /// Causes the internal state of all world objects to be updated
        /// Should be called periodically.
        /// 
        /// </summary>
        /// <param name="elapsedMilliseconds"></param>
        public void Update(long elapsedMilliseconds)
        {
            SDL.SDL_SetRenderDrawColor(renderer.Rend, 0x00, 0x00, 0x00, 0xFF);
            SDL.SDL_RenderClear(renderer.Rend);

            foreach (var asteroid  in asteroids)
            {
                asteroid.Update(elapsedMilliseconds);
                WrapPosition(asteroid);
            }

            player.Update(elapsedMilliseconds);
            WrapPosition(player);

        }
        /// <summary>
        /// Implements the drawing of all game actors
        /// </summary>
        private void DrawAll(Renderer renderer)
        {
            foreach (var asteroid in asteroids)
            {
                asteroid.Draw(renderer.Rend);
            }
            player.Draw(renderer.Rend);

        }

        public List<Actor> GetActors()
        {
            List<Actor> actors = asteroids.Cast<Actor>().ToList();
                actors.Add(player);
            return actors;
        }

        /// <summary>
        /// Wraps a point to the world size
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private void WrapPosition(Actor actor)
        {
            Point point = actor.Position;

            if (actor.Position.X < 0)
            {
                point.X += SizeX;
            }

            if (point.X > SizeX)
            {
                point.X -= SizeX;
            }

            if (point.Y < 0)
            {
                point.Y += SizeY;
            }

            if (point.Y > SizeY)
            {
                point.Y -= SizeY;
            }

            actor.Position = point;

         //   return point;
        }

    }
}
