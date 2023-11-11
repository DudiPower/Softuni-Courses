double priceForKilogramVegetables = double.Parse(Console.ReadLine());

double priceForKilogramFruits = double.Parse(Console.ReadLine());

int sumKilogramsVegetables = int.Parse(Console.ReadLine());

int sumKilogramsFruits = int.Parse(Console.ReadLine());

double priceVegetables = priceForKilogramVegetables * sumKilogramsVegetables;
double priceFruits = priceForKilogramFruits * sumKilogramsFruits;

double sum = (priceVegetables + priceFruits) / 1.94;

Console.WriteLine("{0:0.00}", sum);