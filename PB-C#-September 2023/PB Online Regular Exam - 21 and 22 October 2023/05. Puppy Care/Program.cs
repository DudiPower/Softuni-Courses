int buyQuantityFoodDogKg=int.Parse(Console.ReadLine());
int buyQuantityFoodDogGr = buyQuantityFoodDogKg * 1000;
string input=Console.ReadLine();
int foodCurrentEat = 0;
int allEatFood = 0;

while (input != "Adopted")
{
	foodCurrentEat = int.Parse(input);
	allEatFood+= foodCurrentEat;


	input = Console.ReadLine();
}

if (allEatFood <= buyQuantityFoodDogGr)
{
    Console.WriteLine($"Food is enough! Leftovers: {buyQuantityFoodDogGr - allEatFood} grams.");
}
else
{
	Console.WriteLine($"Food is not enough. You need {allEatFood - buyQuantityFoodDogGr} grams more.");
}




