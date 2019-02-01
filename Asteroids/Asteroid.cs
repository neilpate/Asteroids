using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;

namespace Asteroids
{
    public class Asteroid : Actor
    {
        public Asteroid(string name, Point position, Vector2 velocity, double mass)
        {
            this.Create(name, position, velocity, mass);

        }
    }
}
