using System.Diagnostics.CodeAnalysis;

int numberStudents=int.Parse(Console.ReadLine());

int countLow = 0;
int countAverage = 0;
int countGood = 0;
int countExcellent = 0;
double sum = 0;

for (int i = 1; i <=numberStudents; i++)
{

	double markExam=double.Parse(Console.ReadLine());

	sum += markExam;

	if (markExam>=2.00 && markExam<=2.99)
	{
		countLow++;
		
	}
	else if (markExam <= 3.99)
	{
		countAverage++;
	}
	else if (markExam<=4.99)
	{
        countGood++;	
	}
	else
	{
		countExcellent++;
	}

}

double averageSucces = sum / numberStudents;

Console.WriteLine($"Top students: {(double)countExcellent/numberStudents*100:F2}%");
Console.WriteLine($"Between 4.00 and 4.99: {(double)countGood / numberStudents * 100:F2}%");
Console.WriteLine($"Between 3.00 and 3.99: {(double)countAverage / numberStudents * 100:F2}%");
Console.WriteLine($"Fail: {(double)countLow / numberStudents * 100:F2}%");
Console.WriteLine($"Average: {averageSucces:F2}");