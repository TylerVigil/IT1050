using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class Elevator
    {
        private double maxWeight;
        private Passenger[] Occupants;
        
        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.maxWeight = maxWeight;
        }
        
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double totalWeight = Occupants[0].GetWeight();
            double currentOccupant;
            for(int i = 1; i < Occupants.Length; i++)
            {
                currentOccupant = Occupants[i].GetWeight();
                totalWeight = currentOccupant + totalWeight;
                    
            }
            return totalWeight;
        }
        public bool IsOverMaxCapacity()
        {
            bool v = GetCurrentWeight() > maxWeight;
            if(GetCurrentWeight() > maxWeight)
            {
                v = false;
                System.Console.WriteLine("Wont Function");
            }
            else
            {
                System.Console.WriteLine("Elevator Functions");
                v = true;
            }

            return v;
            
        }
    }
}
