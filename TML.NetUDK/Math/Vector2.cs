using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TML.NetUDK.Math
{
    public class Vector2
    {
        public float X;
        public float Y;
        public int iX
        {
            get
            {
                return (int)X;
            }
        }
        public int iY
        {
            get
            {
                return (int)Y;
            }
        }
        public float Magnitude
        {
            get
            {
                return (float)(System.Math.Sqrt(X * X + Y * Y));
            }
        }
        public Vector2()
            : this(0, 0)
        {

        }
        public Vector2(double x, double y)
        {
            X = (float)x;
            Y = (float)y;
        }
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Vector2 b)
        {
            return X == b.X && Y == b.Y;
        }

        public Vector2 Sub(float x, float y)
        {
            return new Vector2(X - x, Y - y);
        }

        public Vector2 Sub(Vector2 b)
        {
            return new Vector2(X - b.X, Y - b.Y);
        }

        public Vector2 Add(float x, float y)
        {
            return new Vector2(X + x, Y + y);
        }
        public Vector2 Add(Vector2 p)
        {
            return new Vector2(X + p.X, Y + p.Y);
        }


        public Vector2 ScaleTo(float len)
        {
            Vector2 n = Normalize();
            n.SetScale(len);
            return n;
        }

        public Vector2 Normalize()
        {
            Vector2 n = Clone();
            n.SNormalize();
            return n;
        }

        public Vector2 Clone()
        {
            return new Vector2(X, Y);
        }

        public void SetScale(float scale)
        {
            X *= scale;
            Y *= scale;
        }

        public void SNormalize()
        {
            float m = Magnitude;
            X = X / m;
            Y = Y / m;
        }

        public static float RadianToDegree(float radian)
        {
            return (float)(radian * 180.0f / System.Math.PI);
        }

        public static float DegreeToRadian(float angle)
        {
            return (float)(angle * System.Math.PI / 180.0f);
        }

        public void SAdd(Vector2 b)
        {
            X += b.X;
            Y += b.Y;
        }

        public void SAdd(float x, float y)
        {
            X += x;
            Y += y;
        }

        public void SSub(Vector2 b)
        {
            X -= b.X;
            Y -= b.Y;
        }

        public void SSub(float x, float y)
        {
            X -= x;
            Y -= y;
        }

        public void Set(Vector2 b)
        {
            X = b.X;
            Y = b.Y;
        }
        public void Set(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Vector2 RotateDegree(float degree)
        {
            float rad = DegreeToRadian(degree);

            float ca = (float)System.Math.Cos(rad);
            float sa = (float)System.Math.Sin(rad);
            return new Vector2(X * ca - Y * sa, X * sa + Y * ca);
        }

        public Vector2 Invert()
        {
            return new Vector2(-X, -Y);
        }

        public bool IsZero(float epsilon)
        {
            return System.Math.Abs(X) <= epsilon && System.Math.Abs(Y) <= epsilon;
        }
        public bool IsZero()
        {
            return IsZero(0.0000001f);
        }

        public string StriXY()
        {
            return StriXY(true);
        }
        public string StriXY(bool addBracket)
        {
            if (addBracket)
                return "(" + iX + "," + iY + ")";
            return "" + iX + "," + iY;
        }

        public bool IntEquals(Vector2 b)
        {
            return iX == b.iX && iY == b.iY;
        }
        public bool IntEquals(int x, int y)
        {
            return iX == x && iY == y;
        }

        public float getAngleFrom(Vector2 b)
        {
            float dotProd = Dot(b);
            float lenProd = Magnitude * b.Magnitude;
            float divOperation = dotProd / lenProd;
            return RadianToDegree((float)System.Math.Acos(divOperation));
        }

        public float Dot(Vector2 b)
        {
            return X * b.X + Y * b.Y;
        }

        public Vector2 rot90CCW()
        {
            return new Vector2(-Y, X);
        }
        public Vector2 rot90CW()
        {
            return new Vector2(Y, X);
        }

        public float getMaxDiff(Vector2 b)
        {
            float dx = System.Math.Abs(X - b.X);
            float dy = System.Math.Abs(Y - b.Y);
            if (dx > dy) return dx;
            return dy;
        }
    }
}
