double recordSeconds = double.Parse(Console.ReadLine());
double distanceMeters=double.Parse(Console.ReadLine());
double speed=double.Parse(Console.ReadLine());

double swimTime = speed * distanceMeters;

double delayTime = Math.Floor(distanceMeters / 15);
double delaySeconds = delayTime * 12.5;

double sumTimeForSwim = swimTime +delaySeconds;

if (sumTimeForSwim<recordSeconds)
{
	Console.WriteLine($" Yes, he succeeded! The new world record is {sumTimeForSwim:F2} seconds.");
}
else
{
	Console.WriteLine($"No, he failed! He was {Math.Abs(recordSeconds-sumTimeForSwim):F2} seconds slower.");
}

