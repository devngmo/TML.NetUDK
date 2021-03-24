using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TML.NetUDK.Math
{
    public class MathUtils
    {
        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }

        public static float AngleToRad(float angle)
        {
            return (float)(angle * System.Math.PI / 180);
        }
    }
}
