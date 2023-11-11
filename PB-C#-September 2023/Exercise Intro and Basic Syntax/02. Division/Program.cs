using System.Reflection.Metadata.Ecma335;

namespace _02._Division
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number=int.Parse(Console.ReadLine());
			bool isTrue=false;

			if (number % 10 == 0)
			{

				if (number % 2 == 0)
				{
					Console.WriteLine($"The number is divisible by {10}");
					isTrue = true;
				}

				if (!isTrue)
				{
					Console.WriteLine($"The number is divisible by {10}");
				}

            }

			else if (number % 7 == 0)
			{
                Console.WriteLine($"The number is divisible by {7}");
            }

			else if (number % 6 == 0)
			{
				Console.WriteLine($"The number is divisible by {6}");
			}

			else if (number % 3 == 0)
			{
				Console.WriteLine($"The number is divisible by {3}");
			}

			else if (number % 2==0)
			{
				if (number % 3 == 0)
				{
					if (number % 6 == 0)
					{
                        Console.WriteLine($"The number is divisible by {6}");
						isTrue=true;
                    }
				}

				if (!isTrue)
				{
					Console.WriteLine($"The number is divisible by {2}");
				}
			}
			else
			{
                Console.WriteLine("Not divisible");
            }
			
			
		}
	}
}