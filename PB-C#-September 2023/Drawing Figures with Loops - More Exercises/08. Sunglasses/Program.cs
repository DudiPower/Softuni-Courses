using System.ComponentModel.Design;

int n = int.Parse(Console.ReadLine());
int count = 1;
int n1 = 2;

for (int i = 1; i <= 2*n; i++)
{
	Console.Write("*");
}

for (int j = 1;j <= n; j++)
{
	Console.Write(" ");
}

for (int p = 1; p <= 2 * n; p++)
{
	Console.Write("*");
}

Console.WriteLine();



for (int t = 1;t <= n-2; t++)
{

	Console.Write("*");


	for (int r = 1; r <= 2 * n-2; r++)
	{
		Console.Write("/");
	}

	Console.Write("*");

	if (t==n1)
	{
		n1 += 2;
		for (int b = 1; b <= n; b++)
		{
			Console.Write("|");
		}
	}
	else
	{
		for (int b = 1; b <= n; b++)
		{
			Console.Write(" ");
		}
	}
		

	Console.Write("*");

	for (int e = 1; e <= 2 * n - 2; e++)
	{
		Console.Write("/");
	}

	Console.Write("*");

	Console.WriteLine();
}

for (int i = 1; i <= 2 * n; i++)
{
	Console.Write("*");
}

for (int j = 1; j <= n; j++)
{
	Console.Write(" ");
}

for (int p = 1; p <= 2 * n; p++)
{
	Console.Write("*");
}

Console.WriteLine();