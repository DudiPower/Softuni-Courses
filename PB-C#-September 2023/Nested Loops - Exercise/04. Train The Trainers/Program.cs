int numberAppreciatives=int.Parse(Console.ReadLine());

string namePresentation=Console.ReadLine();
double sumMarks = 0;
double allAverageSuccess = 0;
int counterPresentation = 0;

while(namePresentation != "Finish")
{
	counterPresentation++;
	sumMarks = 0;

	for (int i = 1; i <= numberAppreciatives; i++)
	{

		double mark = double.Parse(Console.ReadLine());

	     sumMarks += mark;
	}

	double averageSuccess = sumMarks / numberAppreciatives;
	Console.WriteLine($"{namePresentation} - {averageSuccess:f2}.");

	allAverageSuccess += averageSuccess;
	
	namePresentation = Console.ReadLine();
}

Console.WriteLine($"Student's final assessment is {allAverageSuccess/counterPresentation:F2}.");
