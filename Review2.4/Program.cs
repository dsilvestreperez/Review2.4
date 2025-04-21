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

            Console.WriteLine("Enter the length of the first side (a):");//input side a

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the first side (b):");// inputside b

            double b = Convert.ToDouble(Console.ReadLine());


            double c = Math.Sqrt((a * a) * (b * b));//equation

            Console.WriteLine("The length of the hypotenuse is:" + c);// outputing the equatino

            Console.WriteLine("Thank you for using the Hypotenuse Calculator!");
        }

    }

}
