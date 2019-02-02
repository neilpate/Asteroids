using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;

namespace Asteroids
{
    public class Renderer
    {
        const int SCREEN_WIDTH = 640;
        const int SCREEN_HEIGHT = 480;

        IntPtr window = IntPtr.Zero;

        public IntPtr renderer = IntPtr.Zero;

        public Renderer()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

            window = SDL.SDL_CreateWindow("Test", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
            renderer = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
        }

        public void Test()
        {
            SDL.SDL_SetRenderDrawColor(renderer, 0xFF, 0xFF, 0xFF, 0xFF);
            //Render red filled quad
            var fillRect = new SDL.SDL_Rect { x = SCREEN_WIDTH / 4, y = SCREEN_HEIGHT / 4, w = SCREEN_WIDTH / 2, h = SCREEN_HEIGHT / 2 };
            SDL.SDL_SetRenderDrawColor(renderer, 0xFF, 0x00, 0x00, 0xFF);
            SDL.SDL_RenderFillRect(renderer, ref fillRect);

            SDL.SDL_RenderPresent(renderer);
        }




     
    }
}
