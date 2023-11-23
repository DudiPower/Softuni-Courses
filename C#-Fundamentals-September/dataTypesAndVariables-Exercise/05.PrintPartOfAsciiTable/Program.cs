namespace _05.PrintPartOfAsciiTable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int startCharacters=int.Parse(Console.ReadLine());
			int endCharacters=int.Parse(Console.ReadLine());

			for (int i = startCharacters; i <= endCharacters; i++)
			{
                Console.Write((char)i + " ");
            }
		}
	}
}
