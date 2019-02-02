using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using SDL2;

namespace Asteroids
{
    public class Asteroid : Actor
    {
        const int size = 10;

        public Asteroid(string name, Point initialPosition, Vector2 initialVelocity, double initialAngle, double mass)
        {
            this.Create(name, initialPosition, initialVelocity, initialAngle, mass);

        }

        public void Draw(Renderer renderer)
        {
            SDL.SDL_Point one;

            double angleRadians = Math.PI * Physics.Angle / 180.0;

            one.x = (int)(Position.X + Math.Cos(angleRadians) * size);
            one.y = (int)(Position.Y + Math.Sin(angleRadians) * size);

            SDL.SDL_Point two;
            two.x = (int)(Position.X - Math.Cos(angleRadians) * size);
            two.y = (int)(Position.Y - Math.Sin(angleRadians) * size);

            SDL.SDL_Point[] points = new SDL.SDL_Point[2];

            points[0] = one;
            points[1] = two;

            SDL.SDL_SetRenderDrawColor(renderer.renderer, 0xFF, 0x00, 0x00, 0xFF);
            SDL.SDL_RenderDrawLines(renderer.renderer, points, 2);

         

        }
    }
}
