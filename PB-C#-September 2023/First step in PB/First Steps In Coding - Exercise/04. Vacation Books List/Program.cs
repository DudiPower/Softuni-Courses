int numberPages = int.Parse(Console.ReadLine());

int pagesForHour = int.Parse(Console.ReadLine());

int numberDaysToRead = int.Parse(Console.ReadLine());

int sumHours = numberPages / pagesForHour;

int necessaryHours=sumHours/numberDaysToRead;

Console.WriteLine(necessaryHours);
