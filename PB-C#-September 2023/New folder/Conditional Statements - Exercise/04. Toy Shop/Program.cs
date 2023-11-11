double priceTrip = double.Parse(Console.ReadLine());

int numberPuzzles=int.Parse(Console.ReadLine());
int numberDolls = int.Parse(Console.ReadLine());
int numberBears = int.Parse(Console.ReadLine());
int numberMinions = int.Parse(Console.ReadLine());
int numberTrucks = int.Parse(Console.ReadLine());

//•	Пъзел - 2.60 лв.
//•	Говореща кукла - 3 лв.
//•	Плюшено мече - 4.10 лв.
//•	Миньон - 8.20 лв.
//•	Камионче - 2 лв.


double priceToys = numberPuzzles * 2.60 
	               + numberDolls * 3 
	               + numberBears * 4.10 
	               + numberMinions * 8.20 
	               + numberTrucks * 2;

double numberToys=numberPuzzles+numberDolls+numberBears+numberMinions+numberTrucks;

if (numberToys>=50)
{
	priceToys = priceToys - 0.25 * priceToys;
}

priceToys = priceToys - 0.1 * priceToys;

if(priceToys >= priceTrip)
{
	Console.WriteLine($"Yes! {priceToys -priceTrip:F2} lv left.");
}
else
{
	Console.WriteLine($"Not enough money! {Math.Abs(priceToys-priceTrip):F2} lv needed.");
}