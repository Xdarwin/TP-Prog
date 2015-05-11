using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> m1 = new Matrix<int>(1);
            m1.print();
            Matrix<int> m2 = new Matrix<int>(2);

            Matrix<int> m3 = m1 * m2;




        }
    }
}
