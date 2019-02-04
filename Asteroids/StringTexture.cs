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

        private IntPtr renderer;
        private string font;
        private FontManager fontManager;
        


        Texture texture = new Texture();

        public StringTexture(SDL.SDL_Color colour, IntPtr renderer, string font, FontManager fontManager)
        {
            this.Colour = colour;
            this.renderer = renderer;
            this.font = font;
            this.fontManager = fontManager;
            
        }

        public void LoadFromRenderedText(string text)
        {
            texture.LoadFromRenderedText(text, Colour, renderer, fontManager.GetFont("consolas"));

        }

        public void Render()
        {
            texture.Render(renderer, x, y);
        }



    }
}
