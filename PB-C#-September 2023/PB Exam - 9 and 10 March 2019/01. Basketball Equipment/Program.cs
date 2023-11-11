int yearTax = int.Parse(Console.ReadLine());

double basketballSneakers = yearTax-0.4*yearTax;
double basketballOutfit = basketballSneakers - 0.2 * basketballSneakers;
double basketballBall = basketballOutfit / 4;
double basketballAccesoaries = basketballBall / 5;

double sumPrice = yearTax + basketballSneakers + basketballOutfit + basketballBall + basketballAccesoaries;

Console.WriteLine($"{sumPrice:F2}");

