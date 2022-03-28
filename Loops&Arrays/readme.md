
		{
			string teamName;
			int teamSize;

			string[] playerNames;
			int[] playerNumbers;

			void getTeamInfo()
			{
				System.Console.WriteLine("What is your team's name?");
				teamName = System.Console.ReadLine();
				System.Console.WriteLine("How many players are on your team?");
				teamSize = int.Parse(System.Console.ReadLine());
				playerNames = new string[teamSize];

				playerNumbers = new int[teamSize];

				for (int i = 0; i < teamSize; i++)
				{
					System.Console.WriteLine("Enter Players Name");
					playerNames[i] = (System.Console.ReadLine());
					System.Console.WriteLine("Enter Players Number");
					playerNumbers[i] = int.Parse(System.Console.ReadLine());
				}
			}

			void printTeamInfo()
			{
				System.Console.WriteLine("Team Name: " + teamName);
				for (int i = 0; i < teamSize; i++)
				{
					System.Console.WriteLine("Player Name: " + playerNames[i] + " | Player Number: " + playerNumbers[i] + " |");
				}
			}

			getTeamInfo();

			printTeamInfo();

		}
	}
}
