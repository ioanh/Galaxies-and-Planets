using System;
using System.Collections.Generic;

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

            //static void startGame()
            //{
            //  List<string> ls = new List<string>();
            //  string sentence = Console.ReadLine();
            //  string[] sentenceSplit = sentence.Split();
            // if (sentenceSplit[0] == "add")
            // {
            //    Console.WriteLine("It was added");
            //     ls.Add(sentence);
            //    Console.WriteLine(ls);
            //    startGame();
            //  }
            //  else if (sentenceSplit[0] == "exit")
            //  {

            // }
            //}

            // startGame();

            Boolean isGamePlaying = true;

            while (isGamePlaying)
            {
                string sentence = Console.ReadLine();
                string[] sentenceSplit = sentence.Split();
                if(sentenceSplit[0] == "add")
                {
                    Console.WriteLine("This time it way work");
                    continue;
                }else if(sentenceSplit[0] == "exit")
                {
                    Console.WriteLine("That was boyts");
                    isGamePlaying = false;
                }
            }
        }
    }
}
