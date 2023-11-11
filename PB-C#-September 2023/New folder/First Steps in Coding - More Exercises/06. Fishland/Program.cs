double priceMackerelForKilogram = double.Parse(Console.ReadLine());

double priceSpratForKilogram = double.Parse(Console.ReadLine());

double kilogramsBonito = double.Parse(Console.ReadLine());
double kilogramsSafrid = double.Parse(Console.ReadLine());
double kilogramsMussels=double.Parse(Console.ReadLine());

double priceBonitoForKilogram = priceMackerelForKilogram + 0.6 * priceMackerelForKilogram;		
double priceSafridForKilogram=priceSpratForKilogram+0.8* priceSpratForKilogram;

double priceBonito = kilogramsBonito * priceBonitoForKilogram;
double priceSafrid = kilogramsSafrid * priceSafridForKilogram;
double priceMussels = kilogramsMussels * 7.50;

double sumFish = priceBonito + priceSafrid + priceMussels;

Console.WriteLine("{0:0.00}", sumFish);