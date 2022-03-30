namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPets;
            System.Console.WriteLine("How many pets do you own?");
            totalPets = int.Parse(System.Console.ReadLine());

            Pet pets = new Pet();
            pets.Name = new string[totalPets];
            pets.Age = new int[totalPets];
            pets.Breed = new string[totalPets];

            
            for (int i = 0; i < totalPets; i++)
            {
                System.Console.WriteLine("What is your pets name?");
                pets.Name[i] = System.Console.ReadLine();
                System.Console.WriteLine("What is your pets age?");
                pets.Age[i] = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("What is your pets breed?");
                pets.Breed[i] = System.Console.ReadLine();
            }

            for (int i = 0; i < totalPets; i++)
            {
                Console.WriteLine(pets.Name[i] + " is a " + pets.Breed[i] + " and is " + pets.Age[i] + " years old.");
            }

            int small;
            string name;
            small = pets.Age[0];
            name = pets.Name[0];
            for (int i = 0; i < totalPets; i++)
            {
                if (small > pets.Age[i])
                {
                    small = pets.Age[i];
                    name = pets.Name[i];
                }
            }
            System.Console.WriteLine(name + " is " + small + " so it is the youngest.");

            int large;
            string name2;
            large = pets.Age[0];
            name2 = pets.Name[0];
            for (int i = 0; i < totalPets; i++)
            {
                if (large < pets.Age[i])
                {
                    large = pets.Age[i];
                    name2 = pets.Name[i];
                }
            }
            System.Console.WriteLine(name2 + " is " + large + " so it is the oldest.");
        }
    }
}
