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

        private readonly IntPtr window = IntPtr.Zero;
        public IntPtr Rend { get; private set; }

        private readonly Dictionary<string, Texture> textures = new Dictionary<string, Texture>();
        private readonly Dictionary<string, StringTexture> stringTextures = new Dictionary<string, StringTexture>();



        private FontManager fontManager;

        public Renderer()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

            window = SDL.SDL_CreateWindow("Asterids", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
            Rend = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);

            fontManager = new FontManager();
            fontManager.CreateFont(@"c:\windows\fonts\hyperspace.otf", "hyper", 28);

            var textColor = new SDL.SDL_Color
            {
                r = 0xFF,
                g = 0x32,
                b = 0x90
            };

            var st = new StringTexture(Rend, fontManager.GetFont("hyper"), textColor)
            {
                x = 0,
                y = 0
            };
            stringTextures.Add("fps", st);

            st = new StringTexture(Rend, fontManager.GetFont("hyper"), textColor)
            {
                x = 100,
                y = 100
            };
            stringTextures.Add("score", st);

            st = new StringTexture(Rend, fontManager.GetFont("hyper"), textColor)
            {
                x = 300,
                y = 400
            };
            stringTextures.Add("copyright", st);
        }

        public void DrawActors(List<Actor> actors)
        {
            foreach (var actor in actors)
            {
                actor.Draw(Rend);
            }
        }

        public void Present()
        {
            SDL.SDL_RenderPresent(Rend);
        }

        public void Test()
        {
            //SDL.SDL_SetRenderDrawColor(renderer, 0xFF, 0xFF, 0xFF, 0xFF);
            //Render red filled quad
            //var fillRect = new SDL.SDL_Rect { x = SCREEN_WIDTH / 4, y = SCREEN_HEIGHT / 4, w = SCREEN_WIDTH / 2, h = SCREEN_HEIGHT / 2 };
            //SDL.SDL_SetRenderDrawColor(renderer, 0xFF, 0x00, 0x00, 0xFF);
            //SDL.SDL_RenderFillRect(renderer, ref fillRect);
            SDL.SDL_RenderPresent(Rend);
        }

        public void RenderFpsString(float fps)
        {
            var st = stringTextures["fps"];
            st.LoadFromRenderedText($"{fps:F} FPS");
            st.Render();
        }


        public void RenderScoreString(string score)
        {
            var st = stringTextures["score"];
            st.LoadFromRenderedText(score);
            st.Render();
        }

        public void RenderCopyrightString()
        {
            var st = stringTextures["copyright"];
            st.LoadFromRenderedText("C 1979 ATARI INC");
            st.Render();
        }





    }
}
