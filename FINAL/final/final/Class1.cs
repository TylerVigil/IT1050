
namespace final
{
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
}
