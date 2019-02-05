using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Asteroids
{
    /// <summary>
    /// This is the primary class.
    /// It is responsible for controlling all the actors in play (creation and destruction)
    /// all the game logic
    /// </summary>
    class Game
    {
        World world;
        readonly Renderer renderer;

        readonly Stopwatch stopwatch = new Stopwatch();

        public Game()
        {
            renderer = new Renderer();
            world = new World(renderer);
            stopwatch.Start();
        }

        public void Update()
        {
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            stopwatch.Restart();
            world.Update(elapsedMilliseconds);

            //Not really sure this the best place for these render calls, but 
            //it works and is good enough for now
            renderer.DrawActors(world.GetActors());
            renderer.RenderFpsString(1000.0f/(float)elapsedMilliseconds);
           // renderer.RenderScoreString("Hooray!!!");
            renderer.RenderCopyrightString();
            renderer.Present();
        }

    }
}
