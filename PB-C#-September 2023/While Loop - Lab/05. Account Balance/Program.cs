string input = Console.ReadLine();
double bill = 0;

while (input != "NoMoreMoney")
{
	double inputPayment = double.Parse(input);

	if (inputPayment < 0)
	{
		Console.WriteLine("Invalid operation!");
		break;
	}

	Console.WriteLine("Increase: {0:F2}", inputPayment);

	bill += inputPayment;


	input = Console.ReadLine();
}


Console.WriteLine("Total: {0:F2}", bill);