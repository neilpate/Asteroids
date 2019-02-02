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

            double angleRadians;
            int x;
            int y;

            SDL.SDL_Point[] points = new SDL.SDL_Point[5];

            for (int i = 0; i < 5; i++)
            {
                angleRadians = (Math.PI * (Physics.Angle + i * 90)) / 180.0;
                x = (int)(Math.Cos(angleRadians) * size);
                y = (int)(Math.Sin(angleRadians) * size);

                SDL.SDL_Point point;
                point.x = Physics.Position.X + x;
                point.y = Physics.Position.Y + y;
                //Console.WriteLine($"x: {one.x:F2}   y:{one.y:F2}");
                points[i] = point;
            }

            SDL.SDL_SetRenderDrawColor(renderer.renderer, 0xFF, 0x00, 0x00, 0xFF);

            SDL.SDL_RenderDrawPoint(renderer.renderer, Physics.Position.X, Physics.Position.Y);
            SDL.SDL_RenderDrawLines(renderer.renderer, points, 5);



        }
    }
}
