using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using SDL2;
using static Asteroids.Utility;
using static System.Math;

namespace Asteroids
{
    public class Asteroid : Actor
    {
        const int size = 10;

        public Asteroid(string name, Point initialPosition, Vector2 initialVelocity, 
            float initialAngularVelocity, float initialAngle, float mass)
        {
            this.Create(name, initialPosition, initialVelocity, initialAngle, initialAngularVelocity, mass);
        }

        public override void Draw(IntPtr renderer)
        {

            double angleRadians;
            int x;
            int y;

            SDL.SDL_Point[] points = new SDL.SDL_Point[5];

            for (int i = 0; i < 5; i++)
            {
                angleRadians = DegreesToRadians(Physics.Angle + i * 90);
                x = (int)(Cos(angleRadians) * size);
                y = (int)(Sin(angleRadians) * size);

                SDL.SDL_Point point;
                point.x = Position.X + x;
                point.y = Position.Y + y;
                points[i] = point;
            }

            SDL.SDL_SetRenderDrawColor(renderer, 0xFF, 0x00, 0x00, 0xFF);
            SDL.SDL_RenderDrawPoint(renderer, Position.X, Position.Y);
            SDL.SDL_RenderDrawLines(renderer, points, 5);



        }
    }
}
