//int number =int.Parse(Console.ReadLine());

//for (int i=1; i<=9 ; i++)
//{

//	for (int j=1; j<=9 ; j++)
//	{
//		for (int z=1; z<=9; z++)
//		{

//			for (int k = 1; k <= 9; k++)
//			{

//				if (number % i == 0 &&
//				number % j == 0 && number % z == 0 && number % k == 0)
//				{
//					Console.Write($"{i}{j}{z}{k} ");
//				}

//			}
			
//		}
		
//	}
//}


int n = int.Parse(Console.ReadLine());

for (int i = 1111; i <= 9999; i++)
{

	int number = i;
	bool isMagicNumber = true;

	for (int j = 1; j <= 4; j++)
	{
		int singleNumber = number % 10;

		if (singleNumber == 0 || n % singleNumber != 0)
		{
			isMagicNumber = false;
			break;
		}

		number /= 10;
	}

	if (isMagicNumber)
	{
		Console.Write($"{i} ");
	}
}