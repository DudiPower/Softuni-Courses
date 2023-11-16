namespace _09._Chars_to_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word = "";

			for (int i = 1; i <= 3; i++)
			{
				char symbol= char.Parse(Console.ReadLine());

				word += symbol;
			}

			Console.WriteLine(word);
		}
	}
}
