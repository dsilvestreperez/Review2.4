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

            Console.WriteLine("Enter the length of the first side (a):");//the side of the a of the side

            double a = Convert.ToDouble(Console.ReadLine());//the input of the side a of the hyotenuse

            Console.WriteLine("Enter the length of the first side (b):");//the side of the b for the side

            double b = Convert.ToDouble(Console.ReadLine());//the input for the side b for the side


            double c = Math.Sqrt((a * a) + (b * b));// the equation for the hypotenuse math.Sqrt for the closer

            Console.WriteLine("The length of the hypotenuse is:" + c);//dispay the equation of the two side to one side to find the length

            Console.WriteLine("Thank you for using the Hypotenuse Calculator!");

        }

    }

}
