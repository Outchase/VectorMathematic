using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VectorMathematic.Properties;

namespace VectorMathematic
{
    internal class Vektors
    {
        public float x, y, z;

        public Vektors()
        {
            x = 0;
            y = 0;
            z = 0;

            //vectorLength = CalculateVectorLength(x, y, z); // makes no sense when result is always 0
        }

        public Vektors(float setX, float setY, float setZ)
        {
            x = setX;
            y = setY;
            z = setZ;
        }

        // u-> + v-> = |(uX,uY,uZ) + (vX,vY,vZ) = (uX+vX,uY+vY,uZ+vZ) = (wX,wY,wZ) = w->| 
        public static Vektors operator +(Vektors a1, Vektors a2) {
            Vektors result = new();

            result.x = a1.x + a2.x;
            result.y = a1.y + a2.y;
            result.z = a1.z + a2.z;

            return result;
        }

        // u-> - v-> = |(uX,uY,uZ) - (vX,vY,vZ) = (uX-vX,uY-vY,uZ-vZ) = (wX,wY,wZ) = w->| 
        public static Vektors operator -(Vektors a1, Vektors a2)
        {
            Vektors result = new();

            result.x = a1.x - a2.x;
            result.y = a1.y - a2.y;
            result.z = a1.z - a2.z;

            return result;
        }

        // w -> = s * v-> |w-> = s * (vX,vY,vZ) = (s*vX,s*vY,s*vZ)|
        public static Vektors operator *(Vektors a1, int s)
        {
            Vektors result = new();

            result.x = s * a1.x;
            result.y = s * a1.y;
            result.z = s * a1.z;

            return result;
        }

        public static bool Equals(Vektors a1, Vektors a2)
        {
            bool result = false;

            if (a1 == a2) {
                if (a1.x == a2.x && a1.y == a2.y && a1.z == a2.z) {
                    result = true;
                }
            }

            return result;
        }

        //set functions here as static only functions static

        // v-> = (a1, a2, a3) 3d
        // |v->| =  √(a1.x² + a2.y² + a3.z²) Calculate lenght of vector
        public float CalculateVectorLength(Vektors a1)
        {
            CalculateSquare(a1);
            float result = (float)Math.Sqrt(a1.x + a1.y +a1.z);

            return result;
        }

        // x² //static method parameter as vector set as a²
        public Vektors CalculateSquare(Vektors a1)
        {
            Vektors result = new();

            result.x = (float)Math.Pow(a1.x, 2);
            result.y = (float)Math.Pow(a1.y, 2);
            result.z = (float)Math.Pow(a1.z, 2);

            return result;
        }

        // Formula: dist(u,v)
        // ||u-v|| √[(u.x-v.x)²+(u.y-v.y)²(u.z-v.z)²] || √(u-v)²
        public float CalculateVectorDistance(Vektors u, Vektors v)
        {
            Vektors result = new();

            result.x = u.x - v.x;
            result.y = u.y - v.y;
            result.z = u.z - v.z;

            Vektors tmp = CalculateSquare(result);

            float dist = (float)Math.Sqrt(tmp.x + tmp.y +tmp.z);

            return dist;
        }
    }
}
