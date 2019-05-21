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
            // let's setup an array of int size 10

            int[] red = new int[5];

            Console.WriteLine("enter some numbers");
            Console.WriteLine("enter 'fini' when done");
            string input = "";
            int product = 1;
            int i = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower().Equals("fini")) { break;  }
                red[i++] = Convert.ToInt32(input);
                if (i == red.Length)
                {
                    Console.WriteLine("Out of Array Space");
                    break;
                }
            }

            Console.WriteLine("the product is {0} ", product);
        }
    }
}
