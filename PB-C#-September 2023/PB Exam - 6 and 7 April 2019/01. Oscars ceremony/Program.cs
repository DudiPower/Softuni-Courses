int rentHall=int.Parse(Console.ReadLine());

double statuettes = rentHall - 0.3 * rentHall;
double catering = statuettes - 0.15 * statuettes;
double voicing = catering / 2;

double priceCeremony = rentHall + statuettes + catering + voicing;

Console.WriteLine($"{priceCeremony:F2}");	
