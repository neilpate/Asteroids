using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Asteroids
{
    public static class Utility
    {
        public static float DegreesToRadians(float degrees)
        {
            return (float)PI * degrees / 180.0f;
        }

    }
}
