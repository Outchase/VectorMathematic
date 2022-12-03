using System;
using System.Runtime.Versioning;
using VectorMathematic.Properties;

namespace VectorMathematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vektors vectorA = new Vektors(1,2,3);
            //Vektors vectorB = new Vektors();
            Vektors vectorB = new Vektors(0,-1,2);
            Logics logic = new Logics();
            float distanceVector;

            vectorA.vectorLength = logic.CalculateVectorLength(vectorA.x, vectorA.y, vectorA.z);
            vectorA.vectorSquareLength = logic.CalculateSquare(vectorA.vectorLength);

            vectorB.vectorLength = logic.CalculateVectorLength(vectorB.x, vectorB.y, vectorB.z);
            vectorB.vectorSquareLength = logic.CalculateSquare(vectorB.vectorLength);

            // static
            //distanceVector = CalculateVectorDistance(vectorA, vectorB, logic);

            // non-static
            distanceVector = logic.CalculateVectorDistance(vectorA, vectorB);

            //vectorB.vectorLength = logic.CalculateVectorLength(vectorB.x, vectorB.y, vectorB.z);
            Console.WriteLine(Resources.vectorAName);
            Console.WriteLine(Resources.xEqual+ vectorA.x + Resources.yEqual + vectorA.y + Resources.zEqual + vectorA.z);
            Console.WriteLine(Resources.lenghtEqual + String.Format("{0:0.0000}",vectorA.vectorLength));
            Console.WriteLine(Resources.squareLenghtEqual + String.Format("{0:0.0000}",vectorA.vectorSquareLength));

            Console.WriteLine("\n" + Resources.vectorBName);
            Console.WriteLine(Resources.xEqual + vectorB.x + Resources.yEqual + vectorB.y + Resources.zEqual + vectorB.z);
            Console.WriteLine(Resources.lenghtEqual + String.Format("{0:0.0000}", vectorB.vectorLength));
            Console.WriteLine(Resources.squareLenghtEqual + String.Format("{0:0.0000}", vectorB.vectorSquareLength) +"\n");

            logic.CalculateVectorAddition(vectorA, vectorB);
            logic.CalculateVectorSubtraction(vectorA, vectorB);
            logic.CalculateScalarMultiplication(2, vectorA, "A");
            logic.CalculateScalarMultiplication(2, vectorB, "B");

            Console.WriteLine("\n"+Resources.distanceEqual + String.Format("{0:0.0000}", distanceVector));
        }
/*
        // static
        // Formula: dist(u,v)
        // ||u-v|| √[(u1-v1)²+(u2-v2)²(u3-v3)²]
        static float CalculateVectorDistance(Vektors u, Vektors v, Logics logic)
        {
            float distUVX = logic.CalculateSquare(u.x-v.x);
            float distUVY = logic.CalculateSquare(u.y-v.y);
            float distUVZ = logic.CalculateSquare(u.z-v.z);
          
            float dist = (float)Math.Sqrt(distUVX + distUVY + distUVZ);

            return dist;
        }*/
    }
}
