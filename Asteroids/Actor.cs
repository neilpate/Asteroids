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

        public Physics Physics;

        public void Create(string name, Point position, Vector2 velocity, double angle, double mass)
        {
            this.Name = name;
            Physics = new Physics(mass, position, velocity, angle);

        }

        public void Update(long elapsedMilliseconds)
        {
            Physics.Update(elapsedMilliseconds);
        }
    }
}
