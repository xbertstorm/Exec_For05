using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Console.Write("+");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
