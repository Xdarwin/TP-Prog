using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix<T>
    {

        public T[,] table = new T[4, 4];


        public Matrix() { }


        public Matrix(T nb)
        {
            for (int i = 0; i < table.GetLength(0); i++)
                for (int j = 0; j < table.GetLength(1); j++)
                    table[i, j] = nb;
        }



        public void print()
        {
            for(int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
        }





        public static Matrix<T> operator - (Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>();
            for (int i = 0; i < m1.table.GetLength(0); ++i)
                for (int j = 0; j < m1.table.GetLength(1); ++j)
                    result.table[i, j] = (dynamic)m1.table[i, j] - (dynamic)m2.table[i, j];
            return result;             
        }



        public static Matrix<T> operator * (Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>();
            for(int i = 0; i < m1.table.GetLength(0); i++)
            {
                for(int j = 0; j < m1.table.GetLength(1);j++)
                {
                    for(int k = 0; k < m1.table.GetLength(0);k++)
                        result.table[i,j] += ((dynamic)m1.table[i,k] * (dynamic)m2.table[j,k]);
                }
            }
            return result;
        }




    }
}
