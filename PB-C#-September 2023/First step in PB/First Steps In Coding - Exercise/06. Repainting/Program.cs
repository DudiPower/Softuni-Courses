int nylon = int.Parse(Console.ReadLine());

int paint = int.Parse(Console.ReadLine());

int thinner = int.Parse(Console.ReadLine());

int hoursForWork=int.Parse(Console.ReadLine());

//•	Предпазен найлон - 1.50 лв. за кв. метър
//•	Боя - 14.50 лв. за литър
//•	Разредител за боя - 5.00 лв. за литър
// 0.40 лв.за торбички

double priceNylon = (nylon + 2) * 1.50;

double pricePaint = (paint + 0.1 * paint) * 14.50;

double priceThinner = (double)thinner * 5;

double sumMaterials = priceNylon + pricePaint + priceThinner + 0.40;

double sumWorkers = 0.3 * sumMaterials * hoursForWork;

double finalPrice = sumMaterials + sumWorkers;

Console.WriteLine(finalPrice);

