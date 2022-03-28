namespace SmallestNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			// Simple Function 

			int math(int a, int b, int c, int d)
			{
				return (a + b) * (c - d);
			}

			System.Console.WriteLine(math(4, 5, 10, 4));
			System.Console.WriteLine(math(9, 14, 20, 5));
			System.Console.WriteLine(math(-4, 5, 13, 2));
			System.Console.WriteLine(math(5, 12, 41, 4));
			System.Console.WriteLine(math(12, 8, 23, 41));
			System.Console.WriteLine(math(1, 3, 2, 4));
			System.Console.WriteLine(math(1, 2, 3, 4));

			// Void Function

			void oldEnough()
			{
				System.Console.WriteLine("What is your name?");
				string name = System.Console.ReadLine();
				System.Console.WriteLine("How old are you?");
				int age = int.Parse(System.Console.ReadLine());
				if (age < 18)
				{
					System.Console.WriteLine("My name is " + name + " and I am not old enough to vote.");
				}
				else if (age >= 18 && age <= 20)
				{
					System.Console.WriteLine("My name is " + name + " and I am old enough to vote but not drink.");
				}
				else if (age >= 21)
				{
					System.Console.WriteLine("My name is " + name + " and I am old enough to drink and vote!");
				}
			}

			oldEnough();

			// Non Void Functions With No Parameters

			string getCurrentTime()
			{
				string time = System.DateTime.Now.ToLongDateString();
				return time;
			}

			System.Console.WriteLine(getCurrentTime());
		}
	}
}
