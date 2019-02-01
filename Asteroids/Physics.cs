using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace Asteroids
{
    class Physics
    {
        private double mass;
        private Vector2 velocity;

        public Physics(double mass, Point position, Vector2 velocity)
        {
            this.mass = mass;
            this.velocity = velocity;
        }

        public void Update(double time)
        {

        }
    }
}
