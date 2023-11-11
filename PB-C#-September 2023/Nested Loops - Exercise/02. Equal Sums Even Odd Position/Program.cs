//int startInterval=int.Parse(Console.ReadLine());
//int finalInterval=int.Parse(Console.ReadLine());	

//for (int i = startInterval; i <= finalInterval; i++)
//{
//	string number = Convert.ToString(i);

//	int evenSum = 0;
//	int oddSum = 0;

//	for (int j = 0; j < number.Length; j++)
//	{
//		if (j % 2 == 0)
//		{
//			evenSum += number[j];
//		}
//		else
//		{
//			oddSum += number[j];
//		}
//	}

//	if (evenSum == oddSum)
//	{
//		Console.Write($"{number} ");
//	}

//}


int startInterval = int.Parse(Console.ReadLine());
int finalInterval = int.Parse(Console.ReadLine());

for (int i = startInterval; i <= finalInterval; i++)
{
	string number = Convert.ToString(i);

	int evenSum = 0;
	int oddSum = 0;

	for (int j = 0; j < number.Length; j+=2)
	{
		evenSum += number[j];
		oddSum += number[j+1];

	}

	if (evenSum == oddSum)
	{
		Console.Write($"{number} ");
	}

}