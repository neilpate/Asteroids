using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace Asteroids
{

    public class Physics
    {
        const double DegreesInACircle = 360;

        private double mass;
        private Vector2 velocity;
        private double rotationalVelocity;   //in deg/s
        public double Angle { get; private set; }

        public Physics(double mass, Point position, Vector2 velocity, double angle)
        {
            this.mass = mass;
            this.velocity = velocity;
            Angle = angle;
            this.rotationalVelocity = 36;
        }

        public void Update(long elapsedMilliseconds)
        {
            Angle += rotationalVelocity * elapsedMilliseconds / 1000;
            Angle = Angle % DegreesInACircle;
        }
    }
}
