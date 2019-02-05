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

        public Point Position { get; set; }

        public void Create(string name, Point initialPosition, Vector2 initialVelocity, 
            float initialAngle, float initialAngularVelocity, float mass)
        {
            this.Name = name;
            Physics = new Physics(initialVelocity, initialAngle, initialAngularVelocity, mass);

            Position = initialPosition;

        }

        public abstract void Draw(IntPtr renderer);

        public void Update(long elapsedMilliseconds)
        {
            Physics.Update(elapsedMilliseconds);
            UpdatePosition(elapsedMilliseconds);
        }

        private void UpdatePosition(long elapsedMilliseconds)
        {
            var newPosition = new Point
            {
                X = (int)(Position.X + Physics.velocity.X),
                Y = (int)(Position.Y + Physics.velocity.Y)
            };

            Position = newPosition;

        }
    }
}
