namespace _01.DataTypeFinder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input=Console.ReadLine();
			string dataType;

			while (input != "END")
			{
				if (int.TryParse(input, out int integer))
				{
					dataType = "integer";
					
				}
				else if (double.TryParse(input, out double doubler))
				{
					dataType = "floating point";
				}
				else if (char.TryParse(input, out char character))
				{
					dataType = "character";
					
				}
				else if (bool.TryParse(input, out bool boolean))
				{
					dataType = "boolean";
					
				}
				else
				{
					dataType = "string";
				}

                Console.WriteLine($"{input} is {dataType} type");

				input = Console.ReadLine();
			}
				
		}
	}
}
