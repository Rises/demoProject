using System;
using demoProject.Add;
using demoProject.Subtract;

namespace demoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            AddIntegers add = new AddIntegers(a,b);
            SubtractIntegers sub = new SubtractIntegers(a, b);
            Console.WriteLine("Addition of numbers is " + add.AddNumbers(a,b));
            Console.WriteLine("Subtraction of numbers is " + sub.SubtractNumbers(a, b));
            Console.ReadLine();
        }
    }
}
