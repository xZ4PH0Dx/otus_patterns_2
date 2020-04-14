using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_patterns_2
{
    public class MatrixMultiplier
    {
        public static List<int[]> Sum(List<int[]> matrix1, List<int[]> matrix2)
        {
            var sum = matrix1.Select(t => new int[matrix1.Count]).ToList();

            Parallel.For(0, matrix1.Count, (i) =>
            {
                var count = 0;
                var locker = new object();
                Parallel.For(0, matrix1[i].Length, (j) =>
                {
                    lock (locker)
                    {
                        sum[i][count] = matrix1[i][count] * matrix2[i][count];
                        count++;
                    }
                });
            });

            return sum;
        }
    }
}
