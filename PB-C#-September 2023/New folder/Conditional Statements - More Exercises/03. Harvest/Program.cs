int areaVineYard=int.Parse(Console.ReadLine());	
double grapes=double.Parse(Console.ReadLine());	
int nessecaryLitresVine=int.Parse(Console.ReadLine());
int numberWorkers=int.Parse(Console.ReadLine());

double sumGrapes = areaVineYard * grapes;

double litresVine = 0.4 * sumGrapes / 2.5;

if (litresVine<nessecaryLitresVine)
{
	Console.WriteLine($"It will be a tough winter! More {Math.Floor(nessecaryLitresVine - litresVine)} liters wine needed.");
}
else
{
	double remainingVine =litresVine-nessecaryLitresVine;
	double vineForWorker =remainingVine/numberWorkers;
	Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litresVine)} liters.");
	Console.WriteLine($"{Math.Ceiling(remainingVine)} liters left -> {Math.Ceiling(vineForWorker)} liters per person.");
}