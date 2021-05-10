using System;
using System.Collections.Generic;

namespace Galaxies_and_Planets
{
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
        public string StarLuminosity;

        public Star(string gname, string name, decimal mass, decimal size, int temp, string luminosity)
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

            while (isGamePlaying)
            {
                //TAKING INPUT
                string sentence = Console.ReadLine();
                string[] sentenceSplit = sentence.Split();


                //STARTING
                if(sentenceSplit[0] == "add")
                {
                    continue;
                }else if(sentenceSplit[0] == "exit")
                {
                    isGamePlaying = false;
                }
            }
        }
    }
}
