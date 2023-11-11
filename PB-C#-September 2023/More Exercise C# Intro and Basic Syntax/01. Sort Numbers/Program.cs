namespace _01._Sort_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = 0;
			int secondNumber = 0;
			int thirdNumber = 0;
			int maxNumber = int.MinValue;
			int minNumber = int.MaxValue;

			for (int i = 1; i <= 3; i++)
			{
				int number=int.Parse(Console.ReadLine());

				if (i == 1)
				{
					firstNumber = number;
				}
				else if (i == 2)
				{
					secondNumber = number;
				}
				else if (i == 3)
				{
				    thirdNumber = number;
				}

				if (maxNumber < number)
				{
					maxNumber = number;
				}
				if (minNumber > number)
				{
					minNumber = number;
				}

			}

			if ((firstNumber != maxNumber || firstNumber == maxNumber) && (firstNumber !=minNumber || firstNumber == minNumber))
			{
                Console.WriteLine(maxNumber);
                Console.WriteLine(firstNumber);
                Console.WriteLine(minNumber);
            }
			else if ((secondNumber != maxNumber || secondNumber == maxNumber) && (secondNumber != minNumber || secondNumber == minNumber))
			{
				Console.WriteLine(maxNumber);
				Console.WriteLine(secondNumber);
				Console.WriteLine(minNumber);
			}
			else if ((thirdNumber != maxNumber || thirdNumber == maxNumber) && (thirdNumber != minNumber || thirdNumber == minNumber))
			{
				Console.WriteLine(maxNumber);
				Console.WriteLine(thirdNumber);
				Console.WriteLine(minNumber);
			}
		}
	}
}