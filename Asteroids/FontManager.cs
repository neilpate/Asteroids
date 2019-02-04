using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;

namespace Asteroids
{
    class FontManager
    {
        Dictionary<string, IntPtr> fonts = new Dictionary<string, IntPtr>();

        public FontManager()
        {
            //Initialize SDL_ttf
            if (SDL_ttf.TTF_Init() == -1)
            {
                Console.WriteLine("SDL_ttf could not initialize! SDL_ttf Error: {0}", SDL.SDL_GetError());
            }

        }

        public int CreateFont(string path, string name, int size)
        {
            //Open the font
            IntPtr font = SDL_ttf.TTF_OpenFont(path, size);
            if (font == IntPtr.Zero)
            {
                Console.WriteLine($"Failed to load {path}! SDL_ttf Error: {0}", SDL.SDL_GetError());
            }
            else
            {
                fonts.Add(name, font);
            }
            return 0;
        }

        public IntPtr GetFont(string name)
        {
            IntPtr font;
            fonts.TryGetValue(name, out font);
            return font;
        }
    }
}
