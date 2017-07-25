using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn8._1SorteraArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("==============================");

            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i + 1} {names[i]}");
            }
            Console.WriteLine("==============================");

            Console.Write("Which name do you wish to change? Enter number: ");
            while (loop)
            {
                try
                {
                    int nameToChange = Convert.ToInt32(Console.ReadLine());
                    int indexNameToChange = nameToChange - 1;
                    names[indexNameToChange] = ChangeName(indexNameToChange);
                    Console.WriteLine("==============================");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{i + 1} {names[i]}");
                    }
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("You must enter a number, 1 - 5");
                }
            }
            Console.WriteLine("==============================");
            
            names = SortAlphabetically(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1} {names[i]}");
            }

        }

        private static string[] SortAlphabetically(string[] names, int sortOrder = 0)
        {
            for (int i = 0; i < names.Length; i++)
            {
                int minIndex = i; 

                for (int j = i; j < names.Length; j++)
                {
                    if (sortOrder == 0)
                    {
                        if (names[minIndex].CompareTo(names[j]) > 0)
                        {
                            minIndex = j;
                        }
                    }
                }
                string temp = names[i];
                names[i] = names[minIndex];
                names[minIndex] = temp;
            }
            return names; 
        }

        private static string ChangeName(int nameToChange)
        {
            Console.Write("Enter new name: ");
            string newName = Console.ReadLine();
            return newName;
        }
    }
}
