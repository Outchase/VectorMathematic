using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VectorMathematic
{
    internal class Vektors
    {
        public float x, y, z;

        float vectorLength = CalculateVectorLength(x, y, z);

        public Vektors()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Vektors(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }


        public float CalculateVectorLength(float x, float y, float z)
        {
            float result = 0;

            //float baseSquare = CalculateSquareLength();
            float heightSquare = CalculateSquareLength(z);

            

            return result;
        }

        public float CalculateSquareLength(float addend)
        {
            float result = (float)Math.Pow(addend,2);

            return result;
        }
    }
}
