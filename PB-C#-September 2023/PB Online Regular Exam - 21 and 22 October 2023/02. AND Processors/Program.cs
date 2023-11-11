int necessaryCountProccesors=int.Parse(Console.ReadLine());
int countEmployers=int.Parse(Console.ReadLine());
int workDays=int.Parse(Console.ReadLine());

double allTime = countEmployers * workDays * 8;

double madeProccesors = Math.Floor(allTime / 3);

if (madeProccesors>=necessaryCountProccesors)
{
	double moreProccesors = madeProccesors - necessaryCountProccesors;
	double profit = moreProccesors * 110.10;

	Console.WriteLine($"Profit: -> {profit:F2} BGN");
}
else
{
	double lessProccesors = necessaryCountProccesors - madeProccesors;
	double losses = lessProccesors * 110.10;

	Console.WriteLine($"Losses: -> {losses:F2} BGN");
}