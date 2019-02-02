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

            double angleRadians = Math.PI * Physics.Angle / 180.0;

            int x = (int)(Math.Cos(angleRadians) * size);
            int y = (int)(Math.Sin(angleRadians) * size);

            SDL.SDL_Point one;
            one.x = Position.X + x;
            one.y = Position.Y + y;
            Console.WriteLine($"x: {one.x:F2}   y:{one.y:F2}");



            SDL.SDL_Point two;
            two.x = Position.X + x;
            two.y = Position.Y - y;

            SDL.SDL_Point three;
            three.x = Position.X - x;
            three.y = Position.Y - y;

            SDL.SDL_Point four;
            four.x = Position.X - x;
            four.y = Position.Y + y;

            SDL.SDL_Point[] points = new SDL.SDL_Point[2];

            points[0] = one;
            points[1] = two;

         //   points[2] = three;
         //   points[3] = four;
         //   points[4] = one;



            SDL.SDL_SetRenderDrawColor(renderer.renderer, 0xFF, 0x00, 0x00, 0xFF);

            SDL.SDL_RenderDrawPoint(renderer.renderer, Position.X, Position.Y);
            SDL.SDL_RenderDrawLines(renderer.renderer, points, 2);



        }
    }
}
