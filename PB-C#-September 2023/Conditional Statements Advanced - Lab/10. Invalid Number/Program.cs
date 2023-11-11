int number=int.Parse(Console.ReadLine());

bool number1= (number >= 100 && number <= 200) || number == 0;

if (!number1)
{
	Console.WriteLine("invalid");
}

