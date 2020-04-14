using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Xunit;

namespace otus_patterns_2.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void Sum()
        {
            var matrix1 = new Matrix(@"..\..\..\data\test_1.txt");
            var matrix2 = new Matrix(@"..\..\..\data\test_2.txt");
            var matrix_sum = new Matrix(@"..\..\..\data\test_sum.txt");

            var temp1 = matrix1.Get();
            var temp2 = matrix2.Get();
            var tempSum = matrix_sum.Get();

            var sum = MatrixMultiplier.Sum(temp1, temp2);

            var sumString = JsonConvert.SerializeObject(sum);
            var tempSumString = JsonConvert.SerializeObject(tempSum);
            Assert.Equal(sumString, tempSumString);
        }
    }
}
