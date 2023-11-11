string nameStudent = Console.ReadLine();

int badGradeCount = 0;
int grade = 1;
double sum = 0;

while (grade <= 12)
{
	double mark = double.Parse(Console.ReadLine());

	sum += mark;


	if (mark < 4)
	{
		badGradeCount++;

		if (badGradeCount > 1)
		{
			Console.WriteLine($"{nameStudent} has been excluded at {grade} grade");
			break;
		}
		else
		{
			continue;
		}
	}
	grade++;
}

if(grade > 12) 
{ 
      Console.WriteLine($"{nameStudent} graduated. Average grade: {sum/12:F2}");
}