double budget=double.Parse(Console.ReadLine());
int numberGraphicCards=int.Parse(Console.ReadLine());
int numberProcessors=int.Parse(Console.ReadLine());	
int numberRamMemory=int.Parse(Console.ReadLine());


//Видеокарта – 250 лв./бр.
double priceGraphicCards = numberGraphicCards * 250;

//Процесор – 35% от цената на закупените видеокарти/бр.
// Рам памет – 10% от цената на закупените видеокарти/бр.

double priceProcessors = 0.35 * priceGraphicCards * numberProcessors;
double priceRamMemory = 0.1 * priceGraphicCards * numberRamMemory;

double sum = priceGraphicCards + priceProcessors + priceRamMemory;

if (numberGraphicCards>numberProcessors)
{
	sum = sum - 0.15 * sum;
}

if (sum<=budget)
{
	Console.WriteLine($"You have {budget-sum:F2} leva left!");
}
else
{
	Console.WriteLine($"Not enough money! You need {sum-budget:F2} leva more!");
}



