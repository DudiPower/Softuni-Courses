namespace _06._Strong_number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string number=Console.ReadLine();
			int sum = 0;

			for (int i = 0; i <= number.Length-1; i++)
			{

				int currentNumber = int.Parse(number[i].ToString());

				int factorial = 1;

				for (int j = 1; j<=currentNumber; j++)
				{
					factorial *= j;
				}

				sum += factorial;
			}

			int realNumber=int.Parse(number);

			if (sum == realNumber)
			{
                Console.WriteLine("yes");
            }
			else
			{
                Console.WriteLine("no");
            }
		}
	}
}