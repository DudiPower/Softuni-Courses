using System.Diagnostics.CodeAnalysis;

int n=int.Parse(Console.ReadLine());
int sum = 0;
int value = 0;

for (int i = 1; i <= 2 * n; i++)
{

	int currentNumber=int.Parse(Console.ReadLine());
	sum += currentNumber;	

}

if (sum % n == 0)
{
	value = sum / n;
	Console.WriteLine("Yes, value={0}", value);
}
else
{
	value = sum % n;
	Console.WriteLine("No, maxdiff={0}" ,value);
}

