using System;
using System.Collections.Generic;

namespace Galaxies_and_Planets
{
    //USING APPEND FROM WEB TO APPEND TO ARRAY, BCS IM JS NOOB <3 
    public static class Extensions
    {
        public static T[] Append<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new T[] { item };
            }
            T[] result = new T[array.Length + 1];
            array.CopyTo(result, 0);
            result[array.Length] = item;
            return result;
        }
    }
    public class Galaxy
    {
        public string GalaxyName;
        public string GalaxyType;
        public string GalaxyAge;

        public Galaxy(string name, string type, string age)
        {
            GalaxyName = name;
            GalaxyType = type;
            GalaxyAge = age;
        }
    }

    public class Star
    {
        public string StarGalaxyName;
        public string StarName;
        public decimal StarMass;
        public decimal StarSize;
        public int StarTemp;
        public decimal StarLuminosity;

        public Star(string gname, string name, decimal mass, decimal size, int temp, decimal luminosity)
        {
            StarGalaxyName = gname;
            StarName = name;
            StarMass = mass;
            StarSize = size;
            StarTemp = temp;
            StarLuminosity = luminosity;
        }
    }
    public class Planet
    {
        public string PlanetStarName;
        public string PlanetName;
        public string PlanetType;
        public string SupportLife;

        public Planet(string starname, string name, string type, string supportlife)
        {
            PlanetStarName = starname;
            PlanetName = name;
            PlanetType = type;
            SupportLife = supportlife;
        }
    }
    public class Moon
    {
        public string MoonPlanet;
        public string MoonName;
        public Moon(string planet, string name)
        {
            MoonPlanet = planet;
            MoonName = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Boolean isGamePlaying = true;
            Galaxy[] gArr = { };
            Star[] sArr = { };

            while (isGamePlaying)
            {
                //TAKING INPUT
                string sentence = Console.ReadLine();
                string[] sentenceSplit = sentence.Split();


                //STARTING
                if(sentenceSplit[0] == "add")
                {
                    if(sentenceSplit[1] == "galaxy")
                    {
                        Galaxy newGalaxy = new Galaxy(sentenceSplit[2], sentenceSplit[3], sentenceSplit[4]);
                        gArr = gArr.Append(newGalaxy);
                        Console.WriteLine(gArr.Length);
                        continue;
                    }else if(sentenceSplit[1] == "star")
                    {
                        Star newStar = new Star(sentenceSplit[2], sentenceSplit[3], Decimal.Parse(sentenceSplit[4]), Decimal.Parse(sentenceSplit[5]), int.Parse(sentenceSplit[6]), Decimal.Parse(sentenceSplit[7]) );
                        sArr = sArr.Append(newStar);
                        Console.WriteLine(sArr.Length);
                        continue;
                    }
                }else if(sentenceSplit[0] == "exit")
                {
                    isGamePlaying = false;
                }
            }
        }
    }
}
