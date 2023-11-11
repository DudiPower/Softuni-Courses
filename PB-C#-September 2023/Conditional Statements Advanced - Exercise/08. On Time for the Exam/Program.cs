int hourExam=int.Parse(Console.ReadLine());
int minutesExam=int.Parse(Console.ReadLine());	
int hourArrival=int.Parse(Console.ReadLine());
int minutesArrival = int.Parse(Console.ReadLine());

minutesExam = hourExam * 60 + minutesExam;
minutesArrival = hourArrival * 60 + minutesArrival;

int difference = Math.Abs(minutesArrival - minutesExam);

int hour=0;
int minutes = 0;

if (minutesArrival <= minutesExam) 
{ 

   if (difference <=30)
   {
	Console.WriteLine("On time");
	Console.WriteLine($"{difference} minutes before the start");
   }

   else if (difference >=30 && difference < 60)
   {
	Console.WriteLine("Early");
	Console.WriteLine($"{difference} minutes before the start");

    }
    else
	{
		hour = difference / 60;
		minutes = difference % 60;

		if (minutes<10) 
		{ 
		Console.WriteLine("Early");
		Console.WriteLine($"{hour}:0{minutes} hours before the start");
	     }
        else
        {
			Console.WriteLine("Early");
			Console.WriteLine($"{hour}:{minutes} hours before the start");
		}
    }
 }
else
{

	if (difference < 60)
	{
		Console.WriteLine("Late");
		Console.WriteLine($"{difference} minutes after the start");
	}
	else
	{
		hour = difference / 60;
		minutes = difference % 60;

		if (minutes<10) 
		{ 
		Console.WriteLine("Late");
		Console.WriteLine($"{hour}:0{minutes} hours after the start");
	 }
		else
		{
			Console.WriteLine("Late");
			Console.WriteLine($"{hour}:{minutes} hours after the start");
		}
	}
}



