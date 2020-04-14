using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace otus_patterns_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new Matrix(@"..\..\..\data\1.txt");
            var matrix2 = new Matrix(@"..\..\..\data\2.txt");

            var temp1 = matrix1.Get();
            var temp2 = matrix2.Get();

            var sum = MatrixMultiplier.Sum(temp1, temp2);

            foreach (var t in sum)
            {
                foreach (var t1 in t)
                {
                    Console.Write(t1);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}