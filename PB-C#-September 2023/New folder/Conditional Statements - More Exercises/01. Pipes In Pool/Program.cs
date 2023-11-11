int volumePool = int.Parse(Console.ReadLine());
int litresFirstPipe=int.Parse(Console.ReadLine());
int litresSecondPipe=int.Parse(Console.ReadLine());
double hoursWithoutWorker=double.Parse(Console.ReadLine());

double howFillFirstPipe=litresFirstPipe*hoursWithoutWorker;	
double howFillSecondPipe=litresSecondPipe*hoursWithoutWorker;

double sumFill=howFillFirstPipe+howFillSecondPipe;

if (sumFill <= volumePool)
{
	double percentSumFill = sumFill / volumePool * 100;
	double percentFillFirstPipe = howFillFirstPipe / sumFill * 100;
	double percentFillSecondPipe = howFillSecondPipe / sumFill * 100;
	Console.WriteLine($"The pool is {percentSumFill:F2}% full. Pipe 1: {percentFillFirstPipe:F2}%. Pipe 2: {percentFillSecondPipe:F2}%.");
}
else
{
	Console.WriteLine($"For {hoursWithoutWorker} hours the pool overflows with {sumFill-volumePool:F2} liters.");
}



