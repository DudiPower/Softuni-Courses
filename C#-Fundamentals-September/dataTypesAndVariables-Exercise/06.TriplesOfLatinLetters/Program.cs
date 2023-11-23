namespace _06.TriplesOfLatinLetters
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int number= int.Parse(Console.ReadLine());

			for (int i = 97; i < 97 + number; i++)
			{
				for (int j = 97; j < 97 + number; j++)
				{
					for (int z = 97; z < 97 + number; z++)
					{
                        Console.WriteLine($"{(char)i}{(char)j}{(char)z}");
                    }
				}
			}
		}
	}
}
