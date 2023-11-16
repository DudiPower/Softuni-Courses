using System.Diagnostics.Tracing;

namespace _06._Reversed_Chars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string word = "";

			//for (int i = 1; i <= 3; i++)
			//{
			//	char letter = char.Parse(Console.ReadLine());

			//	word += letter;
			//}

			//for (int j = word.Length-1;j >= 0;j--) 
			//{
			//	Console.WriteLine(word[j]);
			//}

		

			char firstLetter=char.Parse(Console.ReadLine());
			char secondLetter = char.Parse(Console.ReadLine());
			char thirdLetter = char.Parse(Console.ReadLine());

			Console.Write($"{thirdLetter} ");
			Console.Write($"{secondLetter} ");
			Console.Write(firstLetter);
		}
	}
}
