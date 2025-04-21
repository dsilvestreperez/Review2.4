using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consoledocumation
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Welcome to the hypotenuse Calculator");

            Console.WriteLine("Enter the length of the first side (a):");

            double a = Convert.ToDouble(Console.ReadLine());//string varialbe input for side a

            Console.WriteLine("Enter the length of the first side (b):");

            double b = Convert.ToDouble(Console.ReadLine());//string variable input for side b


            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The length of the hypotenuse is:" + c);//Print the output for tehe side c

            Console.WriteLine("Thank you for using the Hypotenuse Calculator!");

        }

    }

}
