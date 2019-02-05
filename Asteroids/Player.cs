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
    public class Player : Actor
    {
        const int size = 25;

        public Player(string name)
        {
            var initialPosition = new Point(250, 250);
            var initialVelocity = new Vector2(0, 0);
            var initialAngle = 0f;
            var initialAngularVelocity = 0f;
            var mass = 100.0f;

            this.Create(name, initialPosition, initialVelocity, initialAngle, initialAngularVelocity, mass);

        }

        public override void Draw(IntPtr renderer)
        {

            double angleRadians;
            int x;
            int y;


            int numSides = 3;
            SDL.SDL_Point[] points = new SDL.SDL_Point[numSides+1];     //+1 as the final point
                                                                        //is the same as the last point
                                                                        //to close the shape

            for (int i = 0; i < (numSides+1); i++)
            {
                angleRadians = (Math.PI * (Physics.Angle + i * (360.0/(float)numSides))) / 180.0;
                x = (int)(Math.Cos(angleRadians) * size);
                y = (int)(Math.Sin(angleRadians) * size);

                SDL.SDL_Point point;
                point.x = Position.X + x;
                point.y = Position.Y + y;
                points[i] = point;
            }

            SDL.SDL_SetRenderDrawColor(renderer, 0x00, 0xFF, 0x00, 0xFF);
            SDL.SDL_RenderDrawPoint(renderer, Position.X, Position.Y);
            SDL.SDL_RenderDrawLines(renderer, points, numSides+1);



        }
    }
}
