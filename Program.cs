using System;
using System.Collections.Generic;

namespace Galaxies_and_Planets
{
    //USING APPEND FROM WEB TO IMMITATE Array.Push(item) <3 
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
            //VARIABLES AND ARRAYS
            Boolean isGamePlaying = true;
            Galaxy[] gArr = { };
            Star[] sArr = { };
            Planet[] pArr = { };
            Moon[] mArr = { };

            while (isGamePlaying)
            {
                //TAKING INPUT
                string sentence = Console.ReadLine();
                string[] sentenceSplit = sentence.Split();


                //STARTING

                //ADDING 
                if(sentenceSplit[0] == "add")
                {
                    if(sentenceSplit[1] == "galaxy")
                    {
                        Galaxy newGalaxy = new Galaxy(sentenceSplit[2], sentenceSplit[3], sentenceSplit[4]);
                        gArr = gArr.Append(newGalaxy);
                        continue;
                    }else if(sentenceSplit[1] == "star")
                    {
                        Star newStar = new Star(sentenceSplit[2], sentenceSplit[3], Decimal.Parse(sentenceSplit[4]), Decimal.Parse(sentenceSplit[5]), int.Parse(sentenceSplit[6]), Decimal.Parse(sentenceSplit[7]) );
                        sArr = sArr.Append(newStar);
                        continue;
                    }else if(sentenceSplit[1] == "planet")
                    {
                        Planet newPlanet = new Planet(sentenceSplit[2], sentenceSplit[3], sentenceSplit[4], sentenceSplit[5]);
                        pArr = pArr.Append(newPlanet);
                        continue;
                    }else if(sentenceSplit[1] == "moon")
                    {
                        Moon newMoon = new Moon(sentenceSplit[2], sentenceSplit[3]);
                        mArr = mArr.Append(newMoon);
                        continue;
                    }

                }else if(sentenceSplit[0] == "exit")
                {
                    //END OF GAME
                    Console.WriteLine("YOU HAVE SHUT DOWN THE APP");
                    isGamePlaying = false;
                }else if(sentenceSplit[0] == "stats")
                {
                    //STATS
                    Console.WriteLine($"----STATS---- \n Galaxies: {gArr.Length} \n Stars: {sArr.Length} \n Planets: {pArr.Length} \n Moons: {mArr.Length} \n ----END OF STATS----");
                    continue;
                }else if (sentenceSplit[0] == "list")
                {
                    //LIST
                    if(sentenceSplit[1] == "galaxies")
                    {
                        Console.WriteLine($"---LIST GALAXIES--- \n ");
                        foreach (Galaxy galaxy in gArr)
                        {
                            Console.WriteLine($"{galaxy.GalaxyName}\n ");
                        }
                        Console.WriteLine($"--- END LIST GALAXIES--- \n ");

                        continue;
                    }else if (sentenceSplit[1] == "stars")
                    {
                        Console.WriteLine($"---LIST STARS--- \n ");
                        foreach(Star star in sArr)
                        {
                            Console.WriteLine($"{star.StarName}\n ");
                        }
                        Console.WriteLine($"---END LIST STARS--- \n ");
                        continue;
                    }else if(sentenceSplit[1] == "planets")
                    {
                        Console.WriteLine($"---LIST PLANETS--- \n ");
                        foreach (Planet planet in pArr)
                        {
                            Console.WriteLine($"{planet.PlanetName}\n ");
                        }
                        Console.WriteLine($"--- END LIST PLANETS--- \n ");
                        continue;
                    }else if(sentenceSplit[1] == "moons")
                    {
                        Console.WriteLine($"---LIST MOONS--- \n ");
                        foreach (Moon moon in mArr)
                        {
                            Console.WriteLine($"{moon.MoonName}\n ");
                        }
                        Console.WriteLine($"---END LIST MOONS--- \n ");
                        continue;
                    }
                }else if (sentenceSplit[0] == "print")
                {
                    //PRINT (WHEN THE CAFFEINE KICKS IN 12:35 AM)
                    foreach (Galaxy galaxy in gArr)
                    {
                        if(galaxy.GalaxyName == sentenceSplit[1])
                        {
                            Console.WriteLine($"---Data for {galaxy.GalaxyName}--- \n Type: {galaxy.GalaxyType} \n Age: {galaxy.GalaxyAge} \n Stars:");
                            foreach(Star star in sArr)
                            {
                                if(star.StarGalaxyName == galaxy.GalaxyName)
                                {
                                    Console.WriteLine($"Name: {star.StarName} \n Class: {star.StarMass}, {star.StarSize}, {star.StarTemp}, {star.StarLuminosity}");
                                    foreach(Planet planet in pArr)
                                    {
                                        if(planet.PlanetStarName == star.StarName)
                                        {
                                            Console.WriteLine($"Name: {planet.PlanetName} \n {planet.PlanetType} \n Support life: {planet.SupportLife}");
                                            foreach(Moon moon in mArr)
                                            {
                                                if(moon.MoonPlanet == planet.PlanetName)
                                                {
                                                    Console.WriteLine($"Moons: {moon.MoonName}");
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            continue;
                        }
                    }
                }
            }
        }
    }
}
