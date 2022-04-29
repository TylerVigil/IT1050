int totalPets;
            System.Console.WriteLine("How many pets do you own?");
            totalPets = int.Parse(System.Console.ReadLine());
            



            Pet[] pets;
            pets = new Pet[totalPets];

            int small;

            for (int i = 0; i < totalPets; i++)
            {
                pets[i] = new Pet();
                pets[i].GetPetName();
                pets[i].GetPetAge();
                pets[i].GetPetBreed();
                pets[i].PrintPetInfo();
            }

            int baseLineAge = pets[0].returnAge();
            int smallestAge;
            string smallestName = pets[0].returnName();

            smallestAge = pets[0].returnAge();
            for (int i = 0; i < totalPets; i++)
            {
                
                if (smallestAge > pets[i].returnAge()) 
                {
                    smallestAge = pets[i].returnAge();
                    smallestName = pets[i].returnName();
                }

            }

            System.Console.Write("The Youngest Pet Is " + smallestName + " And is " + smallestAge + ".");
            
            
            int oldestAge = pets[0].returnAge();
            string oldestName = pets[0].returnName();
            for (int i = 0; i < totalPets; i++)
            {
                if (oldestAge < pets[i].returnAge())
                    {
                    oldestAge = pets[i].returnAge();
                    oldestName = pets[i].returnName();
                    }
            }

            System.Console.WriteLine("The oldest is " + oldestName + " and is " + oldestAge);
