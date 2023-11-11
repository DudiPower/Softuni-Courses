double depositedSum = double.Parse(Console.ReadLine());

int term = int.Parse(Console.ReadLine());

double yearPercent=double.Parse(Console.ReadLine());

double sum = depositedSum + term * (depositedSum * yearPercent/100 / 12);

Console.WriteLine(sum);