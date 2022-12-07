using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        //set functions here as static only functions static
    }
}
