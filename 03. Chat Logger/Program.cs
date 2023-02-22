using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "Chat")
                {
                    list.Add(command[1]);
                }
                else if (command[0] == "Delete")
                {
                    bool contains = false;
                    string current = command[1];
                    int indexContains = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == current)
                        {
                            contains = true;
                            indexContains = i;
                        }

                    }
                    if (contains)
                    {
                        list.RemoveAt(indexContains);
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                else if (command[0] == "Edit")
                {
                    string currentMassage = command[1];
                    bool isTrue = false;
                    int index = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == currentMassage)
                        {
                            isTrue = true;
                            index = i;
                            break;
                        }

                    }
                    if (isTrue)
                    {
                        // mojebi trqbva da vidq indexite pravilno dali ne trqbva purvo da dobavq i posle da mahna -1 !!!!
                        list.RemoveAt(index);
                        if (index == list.Count)
                        {
                            list.Add(command[2]);

                        }
                        else
                        {

                        list.Insert(index, command[2]);
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command[0] == "Pin")
                {
                    string messagge = command[1];
                    int indexMessage = 0;
                    bool contains = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == messagge)
                        {
                            contains = true;
                            indexMessage = i;
                            break;
                            
                        }
                    }
                    if (contains)
                    {
                        list.RemoveAt(indexMessage);
                        list.Add(messagge);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command[0] == "Spam")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        list.Add(command[i]);
                    }
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
