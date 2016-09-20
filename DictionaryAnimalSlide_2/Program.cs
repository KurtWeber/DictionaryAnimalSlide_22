using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAnimalSlide_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize varibales
            string animalName;

            // User inpurt
            Console.Write("Please enter an animal to search: ");
            animalName = Console.ReadLine();
            Console.WriteLine();
            
            // Set up dictionary with animal and numebr of legs
            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("Lion", 4);
            animals.Add("Spider", 8);
            animals.Add("Bear",4);
            animals.Add("Centipede", 100);
            animals.Add("Eagle", 2);
            animals.Add("Monkey", 4);
            // Print out animal with number of legs
            if (animals.ContainsKey(animalName))
            {
                int value = animals[animalName];
                Console.WriteLine("The " + animalName + " has " + value + " legs.\n");
            }
            else // If animal not found
            {
                Console.WriteLine(animalName + " not found in dictionary.\n");
            }
        }
    }
}
