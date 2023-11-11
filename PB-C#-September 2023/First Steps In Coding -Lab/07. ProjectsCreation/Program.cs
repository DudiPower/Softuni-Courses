string name = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());

int nesecarryHours = projects * 3;

Console.WriteLine($"The architect {name} will need {nesecarryHours} hours to complete {projects} project/s.");
