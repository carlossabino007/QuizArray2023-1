using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArray2023_1.Logic
{
    public class TwoDimension
    {
        private int[,] _array;

        public TwoDimension(int m, int n)
        {
            M = m;
            N = n;
            _array = new int[M, N];
        }

        public int M { get; }
        public int N { get; }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i,j]}\t";
                }
                output += "\n";
            }
            return output;
        }

        public OneDimension ToOneDimension() 
        {
            var oneDimension = new OneDimension(M * N);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    oneDimension.Add(_array[i,j]);
                }
            }
            return oneDimension;
        }

        public void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _array[i, j] = random.Next(1, 100);
                }

            }
        }


    }
}
