using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C099999
{
    class Turquoise
    {
        // Driver Class
         
        public static void Main()
        {
            Dog fido = new Dog();
            fido.Run();
        }
    }

    class Dog
    {
        string name;
        string breed;
        int age;
        static int numberOfLegs = 4;

        public void Run()
        {
            this.name = "Ralph";
            Console.WriteLine(this.name);
        }

    }

    class Cat
    {

    }
}
