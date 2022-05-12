# Main Program

        static void Main(string[] args)
        {
            
            Elevator elevator1;
                elevator1 = new Elevator(2, 400);
            Passenger passenger1;
            passenger1 = new Passenger("A1", 180);
            Passenger passenger2;
            passenger2 = new Passenger("A2", 220);

            elevator1.AddOccupant(passenger1,0);
            elevator1.AddOccupant(passenger2, 1);

            elevator1.GetCurrentWeight();

            bool elevator1IsOverMaxCapacity;

            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();


            Elevator elevator2;
            elevator2 = new Elevator(3, 600);
            Passenger passenger3;
            passenger3 = new Passenger("A1", 200);
            Passenger passenger4;
            passenger4 = new Passenger("A2", 200);
            Passenger passenger5;
            passenger5 = new Passenger("A3", 201);

            elevator2.AddOccupant(passenger3,0);
            elevator2.AddOccupant(passenger4, 1);
            elevator2.AddOccupant(passenger5, 2);

            elevator2.GetCurrentWeight();

            bool elevator2IsOverMaxCapaciy = elevator2.IsOverMaxCapacity();

   ## Class Elevator
   
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
       
## Class Passenger
     
      internal class Passenger
    {
        private string name;
        private double weight;
        
        public Passenger(string name, double weight)
        {
            this.name = name; 
            this.weight = weight;
        }
        public string GetName()
        {
            return this.name;
        }
        public double GetWeight()
        {
            return this.weight;
        }

        
    }
