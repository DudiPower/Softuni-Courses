int minutes=int.Parse(Console.ReadLine());
int seconds=int.Parse(Console.ReadLine());	
double lengthFurrow=double.Parse(Console.ReadLine());
int secondsForHundredMeters=int.Parse(Console.ReadLine());

double controlInSeconds = minutes * 60 + seconds;
double timeDelay = lengthFurrow / 120;
double delaySeconds = timeDelay * 2.5;
double timeMarin = (lengthFurrow / 100) * secondsForHundredMeters - delaySeconds;

if (timeMarin<=controlInSeconds)
{
	Console.WriteLine("Marin Bangiev won an Olympic quota!");
	Console.WriteLine($"His time is {timeMarin:F3}.");
}
else
{
	Console.WriteLine($"No, Marin failed! He was {timeMarin-controlInSeconds:F3} second slower.");
	
}