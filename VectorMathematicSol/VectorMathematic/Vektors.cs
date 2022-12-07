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
        public float vectorLength; //remove
        public float vectorSquareLength; //remove

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

        static Vectors operator +(Vectors a1, Vectors a2) {
            static Vectors result = a1 + a2;


            return result;
        }

        //set functions here as static only functions static

        // v-> = (a1, a2, a3) 3d
        // |v->| =  √(a1² + a2² + a3²) Calculate lenght of vector
        public float CalculateVectorLength(float vectorX, float vectorY, float vectorZ)
        {
            float a1 = CalculateSquare(vectorX); //give whole vector
            float a2 = CalculateSquare(vectorY);
            float a3 = CalculateSquare(vectorZ);

            float result = (float)Math.Sqrt(a1 + a2 + a3);
            return result;
        }

        // x² //static method parameter as vector set as a²
        public float CalculateSquare(float addend)
        {
            float result = (float)Math.Pow(addend, 2);

            return result;
        }

        // u-> + v-> = |(uX,uY,uZ) + (vX,vY,vZ) = (uX+vX,uY+vY,uZ+vZ) = (wX,wY,wZ) = w->| 
        public void CalculateVectorAddition(Vektors vectorU, Vektors vectorV)
        {
            float vectorWX = vectorU.x + vectorV.x;
            float vectorWY = vectorU.y + vectorV.y;
            float vectorWZ = vectorU.z + vectorV.z;

            Console.WriteLine(Resources.vectorAdditionTitle);
            Console.WriteLine(Resources.xEqual + vectorWX + Resources.yEqual + vectorWY + Resources.zEqual + vectorWZ + "\n");
        }

        // u-> - v-> = |(uX,uY,uZ) - (vX,vY,vZ) = (uX-vX,uY-vY,uZ-vZ) = (wX,wY,wZ) = w->| 
        public void CalculateVectorSubtraction(Vektors vectorU, Vektors vectorV)
        {
            float vectorWX = vectorU.x - vectorV.x;
            float vectorWY = vectorU.y - vectorV.y;
            float vectorWZ = vectorU.z - vectorV.z;

            Console.WriteLine(Resources.vectorSubtractionTitle);
            Console.WriteLine(Resources.xEqual + vectorWX + Resources.yEqual + vectorWY + Resources.zEqual + vectorWZ + "\n");
        }

        // w -> = s * v-> |w-> = s * (vX,vY,vZ) = (s*vX,s*vY,s*vZ)|
        public void CalculateScalarMultiplication(int s, Vektors v, string vectorName)
        {
            float vectorWX = s * v.x;
            float vectorWY = s * v.y;
            float vectorWZ = s * v.z;

            Console.WriteLine(Resources.scalarMultiplicationTitle1 + s + Resources.scalarMultiplicationTitle2 + vectorName + Resources.scalarMultiplicationTitle3);
            Console.WriteLine(Resources.xEqual + vectorWX + Resources.yEqual + vectorWY + Resources.zEqual + vectorWZ + "\n");
        }

        // Formula: dist(u,v)
        // ||u-v|| √[(u1-v1)²+(u2-v2)²(u3-v3)²]
        public float CalculateVectorDistance(Vektors u, Vektors v)
        {
            float distUVX = CalculateSquare(u.x - v.x);
            float distUVY = CalculateSquare(u.y - v.y);
            float distUVZ = CalculateSquare(u.z - v.z);

            float dist = (float)Math.Sqrt(distUVX + distUVY + distUVZ);

            return dist;
        }
    }
}
