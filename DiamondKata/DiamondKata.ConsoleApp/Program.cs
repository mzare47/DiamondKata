using DiamondKata.ClassLibrary;
using System;
using System.Linq;

namespace DiamondKata.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                var firstNotNullStringInput = args.Where(a => !string.IsNullOrEmpty(a.Trim())).First();
                if (firstNotNullStringInput.Length > 1)
                {
                    Console.WriteLine("Invalid Input!");
                }
                else
                {
                    var input = firstNotNullStringInput.First();
                    Diamond diamond = new Diamond();
                    Console.WriteLine(diamond.Create(input));
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
