using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensarEj9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] triangulo = new string[4,8];
            for (int i = 0; i <=4; i++)
            { 
                for (int j = 0; j<=8; j++)
                {
                    triangulo[i, j] = " ";
                }
            }

        }
    }
}
