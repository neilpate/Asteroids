using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;


namespace Asteroids
{
    class StringTexture
    {
        public string Text { get; set; }
        public SDL.SDL_Color Colour { get; set; }
        public int x;
        public int y;

        private readonly IntPtr renderer;
        private readonly IntPtr font;
        private Texture texture = new Texture();

        public StringTexture(IntPtr renderer, IntPtr font, SDL.SDL_Color colour)
        {
            this.Colour = colour;
            this.renderer = renderer;
            this.font = font;
            
        }

        public void LoadFromRenderedText(string text)
        {
            texture.LoadFromRenderedText(text, Colour, renderer, font) ;
        }

        public void Render()
        {
            texture.Render(renderer, x, y);
        }



    }
}
