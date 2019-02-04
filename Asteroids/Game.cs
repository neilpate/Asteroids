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
        readonly Renderer render;

        readonly Stopwatch stopwatch = new Stopwatch();

        public Game()
        {
            stopwatch.Start();
            render = new Renderer();
          //  render.Test();

            world = new World(render);

        }

        public void Update()
        {
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            stopwatch.Restart();
            world.Update(elapsedMilliseconds);
        }
    }
}
