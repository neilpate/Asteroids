using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using static System.Math;
using static Asteroids.Utility;

namespace Asteroids
{

    public class Physics
    {
        const float DegreesInACircle = 360;

        private float mass;
        public Vector2 velocity;
        private float angularVelocity;   //in deg/s
        public float Angle { get; private set; }
    


        public Physics(Vector2 initialVelocity, float initialAngle, 
            float initialAngularVelocity, float mass)
        {
            this.mass = mass;
            velocity = initialVelocity;
            Angle = initialAngle;
            angularVelocity = initialAngularVelocity;
        }

        public void Update(long elapsedMilliseconds)
        {
            Angle += angularVelocity * elapsedMilliseconds / 1000;
            Angle = Angle % DegreesInACircle;
        }

        public void IncreaseVelocity()
        {
            //Figure out how much movement to add to each component
            //based on the heading (angle)
            var xComponent = 2 * Cos(DegreesToRadians(Angle));
            var yComponent = 2 * Sin(DegreesToRadians(Angle));

            Vector2  tempVelocity = velocity;
            velocity.X = (float)(tempVelocity.X + xComponent);
            velocity.Y = (float)(tempVelocity.Y + yComponent);

        }

        public void RotateClockwise()
        {
            Angle += 10;
        }

        public void RotateAntiClockwise()
        {
            Angle -= 10;
        }


    }
}
