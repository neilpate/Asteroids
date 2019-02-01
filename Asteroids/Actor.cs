using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Asteroids
{
    public abstract class Actor
    {
        public string Name { get; set; }
        Point position;

        Physics physics;

        public void Create(string name, Point position, Vector2 velocity, double mass)
        {
            this.Name = name;
            this.position = position;
            physics = new Physics(mass, position, velocity);

        }
    }
}
