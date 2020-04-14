using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace otus_patterns_2
{
    public class Matrix
    {
        private readonly List<int[]> _matrix = new List<int[]>();

        public Matrix(string path)
        {
            using var reader = new StreamReader(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var tempString = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var tempInt = tempString.Select(int.Parse).ToArray();

                _matrix.Add(tempInt);
            }
        }
        public List<int[]> Get()
        {
            return _matrix;
        }
    }
}
