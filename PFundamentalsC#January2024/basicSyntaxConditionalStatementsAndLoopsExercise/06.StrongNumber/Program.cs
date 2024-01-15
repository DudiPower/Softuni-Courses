/*
2

3451

40585
 
*/
internal class Program
{
	static void Main(string[] args)
	{
		//string number = Console.ReadLine();
		//int realNumber = int.Parse(number);
		//int digit;
		//int sumFactorial = 0;

		//for (int i = 0; i < number.Length; i++)
		//{
		//	digit = number[i] - '0';

		//	int factorial = 1;

		//	for (int j = 1; j <= digit; j++)
		//	{
		//		factorial *= j;
		//	}

		//	sumFactorial += factorial;
		//}

		//if (realNumber == sumFactorial)
		//{
		//          Console.WriteLine("yes");
		//      }
		//else
		//{
		//          Console.WriteLine("no");
		//      }

		int number = int.Parse(Console.ReadLine());
		int realNumber = number;
		int digit;
		int sumFactorial = 0;

		while (realNumber > 0)
		{
			digit = realNumber % 10;
			realNumber = realNumber / 10;

			int factorial = 1;

			for (int i = 1; i <= digit; i++)
			{
				factorial *= i;
			}

			sumFactorial += factorial;
		}

		if (number == sumFactorial)
		{
			Console.WriteLine("yes");
		}
		else
		{
			Console.WriteLine("no");
		}

	}
}

