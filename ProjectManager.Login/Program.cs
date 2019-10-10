using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum (10, 15);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        
    }
}
