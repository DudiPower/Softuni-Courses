int numberRestDays=int.Parse(Console.ReadLine());

int normForPlay = 30000;

int numberWorkDays =365 - numberRestDays;

int timeForPlay = (numberWorkDays * 63 + numberRestDays * 127);

int difference= Math.Abs(timeForPlay - normForPlay);
int hours = difference / 60;
int minutes = difference % 60;


if (timeForPlay > normForPlay)
{
	Console.WriteLine("Tom will run away");
	Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
}
else
{
	Console.WriteLine("Tom sleeps well");
	Console.WriteLine($"{hours} hours and {minutes} minutes less for play ");
}


