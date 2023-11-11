int widthCake = int.Parse(Console.ReadLine());
int lengthCake = int.Parse(Console.ReadLine());

int piecesCake = widthCake * lengthCake;

string input = Console.ReadLine();
int piecesEat;

while (input != "STOP")
{
	piecesEat = int.Parse(input);

	piecesCake -= piecesEat;

	if (piecesCake <= 0)
	{
		Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCake)} pieces more.");
		break;
	}

	input = Console.ReadLine();
}

if (input == "STOP")
{
	Console.WriteLine($"{piecesCake} pieces are left.");
}

