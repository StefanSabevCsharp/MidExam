using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Include")
                {
                    coffes.Add(command[1]);
                }
                else if (command[0] == "Remove")
                {
                    int numbersForRemove = int.Parse(command[2]);
                    if (numbersForRemove > coffes.Count) // movejbi trqbva da e ravno >= !!!!!!!!
                    {
                        continue;
                    }
                    if (command[1] == "first")
                    {
                        coffes.RemoveRange(0, numbersForRemove);
                    }
                    else if (command[1] == "last")
                    {
                        for (int j = 0; j < numbersForRemove; j++)
                        {
                            coffes.RemoveAt(coffes.Count - 1);
                        }
                    }

                }
                else if (command[0] == "Prefer")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    if (index1 >= 0 && index1 < coffes.Count && index2 >= 0 && index2 < coffes.Count)
                    {
                        // da se ubedq za indexite dali sa vutre
                        string current = coffes[index1];
                        coffes[index1] = coffes[index2];
                        coffes[index2] = current;
                    }

                }
                else if (command[0] == "Reverse")
                {
                    coffes.Reverse();
                }


            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffes));
        }
    }
}
