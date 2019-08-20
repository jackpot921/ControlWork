using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        public static string MostPopulatedCity(City[] cities)
        {

            City mostPop = new City();
            foreach (var city in cities)
            {

                if (city.Population > mostPop.Population)
                {
                    mostPop.Name = city.Name;
                    mostPop.Population = city.Population;
                    mostPop.Density = city.Density;
                }
            }
            return $"Most Populated: {mostPop.Name} ({mostPop.Population})";
        }
        public static string LongestName(City[] cities)
        {
            City mostPop = new City();
            mostPop.Name = " ";
            foreach (var city in cities)
            {

                if (city.Name.Length > mostPop.Name.Length)
                {
                    mostPop.Name = city.Name;
                    mostPop.Population = city.Population;
                    mostPop.Density = city.Density;
                }
            }
            return $"Longest Name: {mostPop.Name} ({mostPop.Name.Length} letters)";
        }
        public static void PrintDensity(City[] cities)
        {
            Console.WriteLine("Density: ");
            foreach (var city in cities)
            {
                float density = (float)city.Population / (float)city.Density;
                Console.WriteLine($"        {city.Name} - {density}");
            }
        }

        public struct City
        {
            public string Name;
            public int Population;
            public int Density;

        }
        //Kharkov=1431000,350;Kiev=2804000,839;Las Vegas=603400,352
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            string input = Console.ReadLine();

            string[] result = input.Split(';');
            City[] cities = new City[result.Length];

            for (int i = 0; i < result.Length; i++)
            {
                cities[i].Name = result[i].Split('=')[0];
                cities[i].Population = int.Parse(result[i].Split('=' ,',')[1]);
                cities[i].Density = int.Parse(result[i].Split(',')[1]);
            }

            Console.WriteLine(MostPopulatedCity(cities));
            Console.WriteLine(LongestName(cities));
            PrintDensity(cities);

            

        }
    }
}
