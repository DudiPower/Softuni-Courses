int number1=int.Parse(Console.ReadLine());
int number2=int.Parse(Console.ReadLine());
char symbol=char.Parse(Console.ReadLine());

double result = 0;

if (symbol=='+' || symbol=='-' || symbol=='*')
{
	if (symbol == '+')
	{
		result = number1 + number2;
	}
	else if (symbol == '-')
	{
		result=number1 - number2;
	}
	else
	{
		result = number1 * number2;
	}

	if (result%2==0)
	{
		Console.WriteLine($"{number1} {symbol} {number2} = {result} - even");
	}
	else
	{
		Console.WriteLine($"{number1} {symbol} {number2} = {result} - odd");
	}
}

else
{
	if (number2 == 0)
	{
		Console.WriteLine($"Cannot divide {number1} by zero");
	}

	else if (symbol == '/')
	{
		result = (double)number1 / number2;
		Console.WriteLine($"{number1} {symbol} {number2} = {result:F2}");
	}
	else if (symbol =='%')
	{
		result = number1 % number2;
		Console.WriteLine($"{number1} {symbol} {number2} = {result}");
	}

}