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
            Console.WriteLine("enter some numbers");
            Console.WriteLine("enter 'fini' when done");
            string input = "";
            int product = 1;

            while (true)
            {
                input = Console.ReadLine();
                if (input.Equals("fini")) { break;  }
                
                product *= Convert.ToInt32(input);
            }

            Console.WriteLine("the product is {0} ", product);
        }
    }
}
