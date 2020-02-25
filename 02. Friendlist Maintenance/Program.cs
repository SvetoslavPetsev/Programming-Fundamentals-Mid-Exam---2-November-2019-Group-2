using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main()
        {
            List<string> friendList = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Report")
                {
                    break;
                }
                string[] command = input.Split().ToArray();

                if (command[0] == "Blacklist")
                {
                    string name = command[1];
                    if (friendList.Contains(name))
                    {
                        int index = friendList.IndexOf(name);
                        friendList[index] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < friendList.Count)
                    {
                        if (friendList[index] != "Lost" && friendList[index] != "Blacklisted")
                        {
                            string name = friendList[index];
                            friendList[index] = "Lost";
                            Console.WriteLine($"{name} was lost due to an error.");
                        }
                    }
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    string newName = command[2];

                    if (index >= 0 && index < friendList.Count) 
                    {
                        string currName = friendList[index];
                        friendList[index] = newName;
                        Console.WriteLine($"{currName} changed his username to {newName}.");
                    }
                }
            }

            int countBlackListed = 0;
            int countLost = 0;
            for (int i = 0; i < friendList.Count; i++)
            {
                if (friendList[i] == "Blacklisted")
                {
                    countBlackListed++;
                }
                else if (friendList[i] == "Lost")
                {
                    countLost++;
                }
            }
            Console.WriteLine($"Blacklisted names: {countBlackListed}");
            Console.WriteLine($"Lost names: {countLost}");
            Console.WriteLine(string.Join(" ", friendList));
        }
    }
}
