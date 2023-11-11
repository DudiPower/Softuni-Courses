int foodDogs = int.Parse(Console.ReadLine());
int foodCats = int.Parse(Console.ReadLine());

double priceFoodDogs = foodDogs * 2.50;
double priceFoodCats = foodCats * 4.00;

double sum = priceFoodCats + priceFoodDogs;

Console.WriteLine($"{sum} lv.");