using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                        t[i, j] = 1;
                    Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
       

        
