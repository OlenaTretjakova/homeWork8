using System;

namespace homeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vectors vector1 = new Vectors(2, 14, 9);
            Vectors vector2 = new Vectors(3, 3, 0);

            Vectors vectorSum = new Vectors(Vectors.SumOfVectors(vector1, vector2));
            Console.WriteLine(vectorSum.ToString());

            Vectors vectorMultiply = new Vectors(Vectors.MultipyOfVectors(vector1, vector2));
            Console.WriteLine(vectorMultiply.ToString());

            Vectors vectorDivision = new Vectors(Vectors.DivisionOfVectors(vector1, vector2));
            Console.WriteLine(vectorDivision.ToString());

            Decimal number1 = new Decimal(123, 456);
            Console.Write(number1.ToString());
            Console.WriteLine($": in binary form {number1.Binary()}");

            RGBColor rgbColor = new RGBColor(255, 0, 0);
            string hexColor = rgbColor.ToHex();
            Console.WriteLine(hexColor);



            Console.ReadLine();
        }
    }
}
