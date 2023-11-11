double priceTennisRacket = double.Parse(Console.ReadLine());
int numberTennisRackets=int.Parse(Console.ReadLine());
int numberPairsSneakers=int.Parse(Console.ReadLine());

double pricePairSneakers = priceTennisRacket / 6;

double priceSneakrsAndRackets = numberTennisRackets * priceTennisRacket + numberPairsSneakers * pricePairSneakers;
double priceEquipment = 0.20 * priceSneakrsAndRackets;
double sumPrice = priceSneakrsAndRackets + priceEquipment;

double priceDjokovic = sumPrice / 8;
double priceSponsors = sumPrice * 7 / 8;

Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceDjokovic)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceSponsors)}");