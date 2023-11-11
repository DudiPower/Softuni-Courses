int age=int.Parse(Console.ReadLine());
double priceWashingMachine=double.Parse(Console.ReadLine());	
int priceToy=int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= age; i++)
{

	if (i % 2 == 0)
	{
		sum = sum + i * 5 - 1;
	}
	else
	{
		sum += priceToy;
	}

}

if (sum>=priceWashingMachine)
{
	Console.WriteLine($"Yes! {sum-priceWashingMachine:F2}");
}
else
{
	Console.WriteLine($"No! {priceWashingMachine - sum:F2}");
}

