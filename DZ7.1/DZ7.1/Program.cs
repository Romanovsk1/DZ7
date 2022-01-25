using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;

namespace DZ7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = ClassLibrary1.Divide(5,2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
