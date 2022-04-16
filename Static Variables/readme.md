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
            Pet.totalNumberOfPets=totalPets;
            Pet.sumOfAllPetsAge = 0;

            
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

            Pet.sumOfAllPetsAge = pets.Age[0];
            for (int i = 1; i < totalPets; i++)
            {
                Pet.sumOfAllPetsAge = Pet.sumOfAllPetsAge + pets.Age[i];
            }
            System.Console.WriteLine("You have a total of " + Pet.totalNumberOfPets + " Pets.");
            System.Console.WriteLine("The collective age of all your pets is " + Pet.sumOfAllPetsAge);
            double sum = (double) Pet.sumOfAllPetsAge / (double) Pet.totalNumberOfPets;
            System.Console.WriteLine("The average age of your pets is " + sum);
        }
    }
}
