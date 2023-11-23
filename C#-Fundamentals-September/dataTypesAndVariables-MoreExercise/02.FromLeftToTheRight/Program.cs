namespace _02.FromLeftToTheRight
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberLines = int.Parse(Console.ReadLine());
			string stringLeftSum = "";
			int finishNumber1 = 0;
			string stringRightSum = "";
			float sumDigits = 0;

			for (int i = 1; i <= numberLines; i++)
			{
				string numbersWithSpace = Console.ReadLine();


				stringLeftSum = "";
				for (int j = 0; j <= numbersWithSpace.Length - 1; j++)
				{
				
					if (numbersWithSpace[j] == ' ')
					{

						finishNumber1 = j;
						break;
					}

					stringLeftSum += numbersWithSpace[j];

				}
				stringRightSum = "";
				for (int z = finishNumber1+1 ;z <= numbersWithSpace.Length - 1; z++)
				{
					stringRightSum += numbersWithSpace[z];
				}
				
				long leftSum = long.Parse(stringLeftSum);
				long rightSum = long.Parse(stringRightSum);

				string leftSumString = leftSum.ToString();
				string rightSumString = rightSum.ToString();

				if (leftSum > rightSum)
				{
				     sumDigits = 0;
					for (int y = 1; y <=  leftSumString.Length; y++)
					{
						long divide = leftSum % 10;
					    sumDigits += divide;
						leftSum = leftSum / 10;
					}
				}
				else
				{
					 sumDigits = 0;
					for (int y = 1; y <= rightSumString.Length; y++)
					{
						long divide = rightSum % 10;
						sumDigits += divide;
						rightSum = rightSum / 10;
					}
				}

                Console.WriteLine(sumDigits);

            }
		}
	}
}
