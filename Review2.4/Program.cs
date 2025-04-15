// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the hypotenuse Calculator");

Console.WriteLine("Enter the length of the first side (a):");//side a

double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the length of the first side (b):");// side b

double b = Convert.ToDouble(Console.ReadLine());


double c = Math.Sqrt((a * a) * (b * b));//equation

Console.WriteLine("The length of the hypotenuse is:" + c);

Console.WriteLine("Thank you for using the Hypotenuse Calculator!");