using System;

namespace Galaxies_and_Planets
{
    public class Planet
    {
    }
    class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine();
            //string[] inputSubs = input.Split();

           // foreach (string sub in inputSubs)
            //{
            //    Console.WriteLine($"Subsstring {sub}");
            //}

           // if (inputSubs[0] == "as")
            //{
            //    Console.WriteLine("qsha");
            //}

            static void startGame()
            {
                string sentence = Console.ReadLine();
                string[] sentenceSplit = sentence.Split();
                if (sentenceSplit[0] == "add")
                {
                    Console.WriteLine("It was added");
                    startGame();
                }
                else
                {
                    startGame();
                }
            }

            startGame();
        }
    }
}
