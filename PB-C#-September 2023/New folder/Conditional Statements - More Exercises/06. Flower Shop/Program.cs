int numberMagnolias=int.Parse(Console.ReadLine());
int numberHyacinths=int.Parse(Console.ReadLine());
int numberRoses=int.Parse(Console.ReadLine());
int numberCactuses=int.Parse(Console.ReadLine());
double priceGift=double.Parse(Console.ReadLine());

//  Магнолии – 3.25 лева
//	Зюмбюли – 4 лева
//	Рози – 3.50 лева
//	Кактуси – 8 лева

double priceOrder = numberMagnolias * 3.25 + numberHyacinths * 4 + numberRoses * 3.50 + numberCactuses * 8;

double priceOrderWithoutTax =priceOrder - 0.05 * priceOrder;

if (priceOrderWithoutTax>=priceGift)
{
	Console.WriteLine($"She is left with {Math.Floor(priceOrderWithoutTax-priceGift)} leva.");
}
else
{
	Console.WriteLine($"She will have to borrow {Math.Ceiling(priceGift-priceOrderWithoutTax)} leva.");
}

