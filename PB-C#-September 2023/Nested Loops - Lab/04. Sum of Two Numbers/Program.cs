//int startInterval=int.Parse(Console.ReadLine());
//int finishInterval=int.Parse(Console.ReadLine());	
//int magicNumber=int.Parse(Console.ReadLine());
//int counter = 0;
//bool magicCombination = false;

//for (int i = startInterval; i <= finishInterval; i++)
//{
//	for (int j = startInterval; j <= finishInterval; j++)
//	{
//		counter++;

//		if (i + j == magicNumber)
//		{
//			magicCombination = true;
//			Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
//		}

//	}
//	if (magicCombination == true)
//	{
//	      break;
//	}
//}

//if (!magicCombination)
//{
//	Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
//}




using System;

int startInterval = int.Parse(Console.ReadLine());
int finishInterval = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int counter = 0;
int sum = 0;

for (int i = startInterval; i <= finishInterval; i++)
{
	for (int j = startInterval; j <= finishInterval; j++)
	{
		counter++;
		sum = i + j;

		if (sum == magicNumber)
		{
			Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
			break;
		}

	}
	if (sum == magicNumber)
	{
		break;
	}
}
if(sum !=magicNumber)
Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");



