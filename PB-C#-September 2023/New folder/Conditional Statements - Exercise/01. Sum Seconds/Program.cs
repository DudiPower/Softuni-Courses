int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int sumTime = firstTime + secondTime + thirdTime;

int minutes = sumTime / 60;
int seconds=sumTime % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");
