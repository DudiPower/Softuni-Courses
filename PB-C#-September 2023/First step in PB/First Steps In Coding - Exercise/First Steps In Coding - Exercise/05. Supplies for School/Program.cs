int numberPens = int.Parse(Console.ReadLine());

int numberMarkers = int.Parse(Console.ReadLine());

int litrePreparation = int.Parse(Console.ReadLine());

int discount=int.Parse(Console.ReadLine());

//•	Пакет химикали - 5.80 лв. 
//•	Пакет маркери - 7.20 лв. 
//	Препарат - 1.20 лв (за литър)

double pricePens = numberPens * 5.80;
double priceMarkers = numberMarkers * 7.20;
double pricePreparation = litrePreparation * 1.20;

double price = pricePens + priceMarkers + pricePreparation;

double finalPrice = price - (double)discount / 100 * price;

Console.WriteLine(finalPrice);