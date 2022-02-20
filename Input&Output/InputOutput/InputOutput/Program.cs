namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your first name?"); // For 1st part of assignment.
            string firstName;
            firstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your middle name?");
            string middleName;
            middleName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            string lastName;
            lastName = System.Console.ReadLine();
            System.Console.WriteLine("Thank you! Press any key to continue...");
            System.Console.ReadKey();

            System.Console.WriteLine("How many tall are you in feet?"); // For 2nd part of assignment.
            double userHeight;
            userHeight = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine(userHeight * 30.48);
            System.Console.WriteLine("Press Any Key To Continue...");
            System.Console.ReadKey();

            System.Console.WriteLine("How old are you?"); // For 3rd part of assignment.
            int age;
            age = int.Parse(System.Console.ReadLine());
            bool oldEnoughToVote = age >= 18;
            System.Console.WriteLine(oldEnoughToVote);
            System.Console.WriteLine("You are old enough to vote, are you a citizen?");
            bool isCitizen;
            isCitizen = System.Console.ReadLine().ToLower().StartsWith("y");
            //isCitizen = bool.Parse(System.Console.ReadLine());
            bool canVote;
            canVote = isCitizen && true;
            System.Console.WriteLine(canVote);
            System.Console.WriteLine("You are above 18 and a citizen, you are eligible to vote.");
            System.Console.ReadKey();

            



            


                
        }
    }
}