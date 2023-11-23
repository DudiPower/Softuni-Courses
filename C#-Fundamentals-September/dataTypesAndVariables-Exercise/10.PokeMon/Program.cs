namespace _10.PokeMon
{
	internal class Program
	{
		static void Main(string[] args)
		{
	         int  pokemonPokePower = int.Parse(Console.ReadLine()); // N
			 int distanceBetweenTargets = int.Parse(Console.ReadLine()); // M
			 int exhaustionFactor = int.Parse(Console.ReadLine()); // Y
			int countPoked = 0;
			int leftPower = 0;
			int currentPokemonPokePower = pokemonPokePower;
			

			 while (currentPokemonPokePower > distanceBetweenTargets)
			 {
				leftPower = currentPokemonPokePower - distanceBetweenTargets;
				countPoked++;

				currentPokemonPokePower = leftPower;

				if (currentPokemonPokePower == 0.5 * pokemonPokePower)
				{
					if (currentPokemonPokePower < exhaustionFactor)
					{
						leftPower = currentPokemonPokePower - distanceBetweenTargets;
					}
					else
					{
						int divideOperation = currentPokemonPokePower / exhaustionFactor;
						currentPokemonPokePower = divideOperation;
					}
				}

			 }

            Console.WriteLine(currentPokemonPokePower);
            Console.WriteLine(countPoked);
        }
	}
}
