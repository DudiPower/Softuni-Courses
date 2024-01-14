/*

  
  
  
*/
using System.Reflection.Metadata.Ecma335;

internal class Program
{
	static void Main(string[] args)
	{
		int number = int.Parse(Console.ReadLine());
		bool divisibleBy2 = false;
		bool divisibleBy3 = false;
		bool divisibleBy6 = false;
		bool divisibleBy7 = false;
		bool divisibleBy10 = false;
		int maxDivision = 0;

		if (number % 2 == 0)
		{
			divisibleBy2 = true;
			maxDivision = 2;
        }
		if (number % 3 == 0)
		{
			divisibleBy3 = true;
			maxDivision = 3;

		}
		if (number % 6 == 0)
		{
			divisibleBy6 = true;
			maxDivision = 6;

		}
		if(number % 7 == 0)
		{
			divisibleBy7 = true;
			maxDivision = 7;
		}
		if (number % 10 == 0)
		{
			divisibleBy10 = true;
			maxDivision = 10;
		}



		if(divisibleBy2 == false && divisibleBy3 == false && divisibleBy6 == false && divisibleBy7 == false && divisibleBy10 == false)
		{
            Console.WriteLine("Not divisible");
        }
		else
		{
			Console.WriteLine($"The number is divisible by {maxDivision}");
		}
        

	}
}

