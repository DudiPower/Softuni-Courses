int days=int.Parse(Console.ReadLine());

double quantityBrandy = 0;
double degreeBrandy = 0;
double sumBrandy = 0;
double sumDegrees = 0;

for (int i = 1; i <= days; i++)
{
	quantityBrandy = double.Parse(Console.ReadLine());
	degreeBrandy = double.Parse(Console.ReadLine());

	sumBrandy += quantityBrandy;

	sumDegrees = sumDegrees + degreeBrandy * quantityBrandy;
}

double averageDegree = sumDegrees / sumBrandy;

Console.WriteLine($"Liter: {sumBrandy:F2}");
Console.WriteLine($"Degrees: {averageDegree:F2}");

if (averageDegree < 38)
{
	Console.WriteLine("Not good, you should baking!");
}
else if (averageDegree >=38 && averageDegree <=42)
{
	Console.WriteLine("Super!");
}
else
{
	Console.WriteLine("Dilution with distilled water!");
}
