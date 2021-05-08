using System;

namespace Galaxies_and_Planets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] inputSubs = input.Split();

            foreach (string sub in inputSubs)
            {
                Console.WriteLine($"Subsstring {sub}");
            }

            if (inputSubs[0] == "as")
            {
                Console.WriteLine("qsha");
            }
        }
    }
}
