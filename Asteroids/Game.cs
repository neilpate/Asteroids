using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SDL2;

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

        /// <summary>
        /// Main update loop
        /// Returns true is the aplication should exit
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            stopwatch.Restart();
            bool exit = false;

            SDL.SDL_Event e;
            while (SDL.SDL_PollEvent(out e) != 0)
            {
                //User requests quit
                if (e.type == SDL.SDL_EventType.SDL_QUIT)
                {
                    exit = true;
                }
                //User presses a key
                else if (e.type == SDL.SDL_EventType.SDL_KEYDOWN)
                {
                    //Select surfaces based on key press
                    switch (e.key.keysym.sym)
                    {
                        case SDL.SDL_Keycode.SDLK_w:
                            world.player.Physics.IncreaseVelocity();
                            break;

                        case SDL.SDL_Keycode.SDLK_DOWN:
                            break;

                        case SDL.SDL_Keycode.SDLK_a:
                            world.player.Physics.RotateAntiClockwise();
                            break;

                        case SDL.SDL_Keycode.SDLK_d:
                            world.player.Physics.RotateClockwise();

                            break;

                        default:
                            break;
                    }
                }
                Console.WriteLine(e.type.ToString());



            }

            world.Update(elapsedMilliseconds);

            //Not really sure this the best place for these render calls, but 
            //it works and is good enough for now
            renderer.DrawActors(world.GetActors());
            renderer.RenderFpsString(1000.0f/(float)elapsedMilliseconds);
           // renderer.RenderScoreString("Hooray!!!");
            renderer.RenderCopyrightString();
            renderer.Present();

            return exit;
        }

    }
}
