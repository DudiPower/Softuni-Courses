int numberBadMarks=int.Parse(Console.ReadLine());

int countBadMarks = 0;
int numberProblems = 0;
int sumMarks = 0;

string lastProblem = string.Empty;

string nameProblem = Console.ReadLine();

while (nameProblem != "Enough")
{
    lastProblem = nameProblem;
    int mark=int.Parse(Console.ReadLine());

    sumMarks += mark;
    numberProblems++;

    if (mark <= 4)
    {
        countBadMarks++;

        if (countBadMarks == numberBadMarks)
        {
            Console.WriteLine($"You need a break, {countBadMarks} poor grades.");
            break;
        }
    }

	nameProblem = Console.ReadLine();
}

if (nameProblem == "Enough")
{
    Console.WriteLine($"Average score: {(double)sumMarks/numberProblems:F2}");
    Console.WriteLine($"Number of problems: {numberProblems}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
