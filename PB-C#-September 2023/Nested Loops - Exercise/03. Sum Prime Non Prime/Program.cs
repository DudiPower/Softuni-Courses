string input = Console.ReadLine();
int sumPrimeNumber = 0;
int sumNonPrimeNumber = 0;


while (input != "stop")
{
   int number =int.Parse(input);


	if (number < 0)
	{
		Console.WriteLine("Number is negative.");
		input = Console.ReadLine();
		continue;
	}

	bool isNonPrimeNumber = false;

	for (int i = 2; i < number; i++)
	{
		if (number % i == 0) 
		{
			sumNonPrimeNumber += number;
			isNonPrimeNumber=true;
			break;
		}
	}

    if (!isNonPrimeNumber)
    {
		sumPrimeNumber += number;

	}

    input = Console.ReadLine();
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumber}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumber}");	
