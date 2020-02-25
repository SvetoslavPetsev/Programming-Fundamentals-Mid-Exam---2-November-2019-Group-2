using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main()
        {
            List<string> ownedTanks = Console.ReadLine().Split(", ").ToList();
            int numberInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberInput; i++)
            {
                string[] command = Console.ReadLine().Split(", ").ToArray();

                if (command[0] == "Add")
                {
                    string tankName = command[1];
                    if (!ownedTanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank successfully bought");
                        ownedTanks.Add(tankName);
                    }
                    else
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string tankName = command[1];
                    if (ownedTanks.Contains(tankName))
                    {
                        ownedTanks.Remove(tankName);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < ownedTanks.Count)
                    {
                        ownedTanks.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string tankName = command[2];
                    if (index >= 0 && index < ownedTanks.Count)
                    {
                        if (!ownedTanks.Contains(tankName))
                        {
                            ownedTanks.Insert(index, tankName);
                            Console.WriteLine("Tank successfully bought");
                        }
                        else
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", ownedTanks));
        }
    }
}
