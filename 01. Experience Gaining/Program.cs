using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main()
        {
            double expNeeded = double.Parse(Console.ReadLine());
            int battle = int.Parse(Console.ReadLine());
            int battleCount = 0;
            double playerExp = 0;
            bool haveNeededExp = false;
            for (int i = 1; i <= battle; i++)
            {
                battleCount++;
                double expGained = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    expGained *= 1.15;
                }
                if (i % 5 == 0)
                {
                    expGained *= 0.9;
                }
                playerExp += expGained;

                if (playerExp >= expNeeded)
                {
                    haveNeededExp = true;
                    break;
                }

            }
            if (haveNeededExp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCount} battles.");
            }
            else
            {
                double diff = expNeeded - playerExp;
                Console.WriteLine($"Player was not able to collect the needed experience, {diff:F2} more needed.");
            }
        }
    }
}
