using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C099999
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string num1 = Console.ReadLine();

            Console.WriteLine("please enter the 2nd number");
            string num2 = Console.ReadLine();

            double sum = Convert.ToDouble(num1) / Convert.ToDouble(num2);

            Console.WriteLine(sum);

        }
    }
}
