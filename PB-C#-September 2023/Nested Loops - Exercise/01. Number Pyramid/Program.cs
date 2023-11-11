int n =int.Parse(Console.ReadLine());

int currentNumber = 0;
bool isTrue = false;

for (int row = 1; row <= n; row++)
{
	
	for (int col = 1; col <= row; col++)
	{

		currentNumber++;
		if (currentNumber > n)
		{
			isTrue = true;
			break;
		}

		Console.Write($"{currentNumber} ");
	}
	Console.WriteLine();

	if (isTrue)
	{
		break;
	}
}
