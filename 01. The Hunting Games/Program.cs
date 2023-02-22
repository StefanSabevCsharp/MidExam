using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfThePlayers = int.Parse(Console.ReadLine());
            double totalEnergyOFgroup = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());
            double energyLossforThisDay = double.Parse(Console.ReadLine());
            double totalWater = days * numberOfThePlayers * waterPerDayPerPerson;
            double totalFood = days * numberOfThePlayers * foodPerDayPerPerson;
            int currentDay = 1;
            while (true)
            {
                if (totalEnergyOFgroup - energyLossforThisDay <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }
                else
                {
                totalEnergyOFgroup -= energyLossforThisDay;

                }
                if (currentDay % 2 == 0)
                {
                    double waterDelete = totalWater * 0.3;// 263 a trqbva da e 237.3
                    totalWater -= waterDelete;
                    totalEnergyOFgroup *= 1.05;
                }
                if (currentDay % 3 == 0)
                {
                    double foodDelete = totalFood / numberOfThePlayers; // 72
                    totalFood -= foodDelete;
                    totalEnergyOFgroup *= 1.10;
                }
                

                currentDay++;
                days--;
                if (days == 0)
                {
                    break;
                }
                energyLossforThisDay = double.Parse(Console.ReadLine());
            }
            if (totalEnergyOFgroup >= 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {totalEnergyOFgroup:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }

        }
    }
}
