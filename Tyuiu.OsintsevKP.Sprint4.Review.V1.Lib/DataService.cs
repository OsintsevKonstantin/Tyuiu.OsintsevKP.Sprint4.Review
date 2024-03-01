using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.OsintsevKP.Sprint4.Review.V1.Lib
{
    public class DataService
    {

        public int Calculate(int rows, int columns, string value) {

            int[,] mtrx = new int[rows, columns];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }
               
            } int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                         if (mtrx[i, j]%2 == 0)
                        {
                            count++;
                        }
                
                    }
                }
               return count;
              

            
        }
    }
}
