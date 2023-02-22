using System;

namespace FIrst
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());
            
            double totalWater = waterPerPerson * numPlayers * days ;
            double totalFood = numPlayers * foodPerDay * days;

            for (int i = 0; i < days; i++)
            {
                double energyLossperDay = double.Parse(Console.ReadLine());
                groupEnergy -= energyLossperDay;
                if (groupEnergy <= 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    double currentwaterdrop = totalWater / 3;
                    totalWater -= currentwaterdrop;
                }
                if (i % 3 == 0)
                {
                    totalFood /= numPlayers;
                    groupEnergy *= 1.1;
                }


                
                

            }
            if (groupEnergy>=0)
            {
                Console.WriteLine($"You are ready for the quest.You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy.You will be left with {totalFood:f2} food and {totalWater:f2} water");
            }
        }
    }
}
