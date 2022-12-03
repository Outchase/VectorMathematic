using System;

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

            //distanceVector = CalculateVectorDistance(vectorA, vectorB, logic);

            //non-static
            distanceVector = logic.CalculateVectorDistance(vectorA, vectorB);

            //vectorB.vectorLength = logic.CalculateVectorLength(vectorB.x, vectorB.y, vectorB.z);
            Console.WriteLine("<Vector A>");
            Console.WriteLine(" X= " + vectorA.x);
            Console.WriteLine(" Y= " + vectorA.y);
            Console.WriteLine(" Z= " + vectorA.z);
            Console.WriteLine(" Lenght (x)= " + String.Format("{0:0.0000}",vectorA.vectorLength));
            Console.WriteLine(" Square Lenght (x²)= " + String.Format("{0:0.0000}",vectorA.vectorSquareLength));

            Console.WriteLine("\n<Vector B>");
            Console.WriteLine(" X= " + vectorB.x);
            Console.WriteLine(" Y= " + vectorB.y);
            Console.WriteLine(" Z= " + vectorB.z);
            Console.WriteLine(" Lenght (x)= " + String.Format("{0:0.0000}", vectorB.vectorLength));
            Console.WriteLine(" Square Lenght (x²)= " + String.Format("{0:0.0000}", vectorB.vectorSquareLength) +"\n");

            logic.CalculateVectorAddition(vectorA, vectorB);
            logic.CalculateVectorSubtraction(vectorA, vectorB);
            logic.CalculateScalarMultiplication(2, vectorA, "A");
            logic.CalculateScalarMultiplication(2, vectorB, "B");

            Console.WriteLine("\nDistance between vector A & Vector B= " + String.Format("{0:0.0000}", distanceVector));
        }
/*
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
