int numberDays=int.Parse(Console.ReadLine());
int leftFood=int.Parse(Console.ReadLine());
double foodDogForDay=double.Parse(Console.ReadLine());
double foodCatForDay=double.Parse(Console.ReadLine());
double foodTurtleForDayGram=double.Parse(Console.ReadLine());

double foodTurtleForDayKilogram = foodTurtleForDayGram / 1000;

double sumAteFoodForDay = foodDogForDay + foodCatForDay + foodTurtleForDayKilogram;
double sumAteFood = sumAteFoodForDay * numberDays;

if (sumAteFood <= leftFood)
{
	Console.WriteLine($"{Math.Floor(leftFood-sumAteFood)} kilos of food left.");
}
else
{
	Console.WriteLine($"{Math.Ceiling(sumAteFood-leftFood)} more kilos of food are needed.");
}


