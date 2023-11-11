using System.Diagnostics.CodeAnalysis;

int n=int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;
int sum = 0;

for (int i = 1; i <=n; i++)
{
	int currentNumber=int.Parse(Console.ReadLine());

	if (currentNumber > maxNumber)
	{
		maxNumber=currentNumber;
	}

	sum += currentNumber;
}

int finalSum = sum - maxNumber;

if (finalSum==maxNumber)
{
	Console.WriteLine("Yes");
	Console.WriteLine("Sum = " + maxNumber);
}
else
{
	Console.WriteLine("No");
	Console.WriteLine("Diff = " + Math.Abs(maxNumber - finalSum));
}