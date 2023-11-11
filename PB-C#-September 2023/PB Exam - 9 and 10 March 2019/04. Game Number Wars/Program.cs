string nameFirstPlayer=Console.ReadLine();
string nameSecondPlayer=Console.ReadLine();

string input =Console.ReadLine();
int cardSecondPlayer=int.Parse(Console.ReadLine());
int differenceFirstPlayer = 0;
int differenceSecondPlayer = 0;
int cardFirstPlayer = 0;
string winner=string.Empty;
int difference = 0;

while (input != "End of game")
{
    
    cardFirstPlayer = int.Parse(input);

    if (cardFirstPlayer > cardSecondPlayer)
    {
        differenceFirstPlayer = differenceFirstPlayer + (cardFirstPlayer - cardSecondPlayer);
    }
    else if (cardFirstPlayer < cardSecondPlayer)
    {
        differenceSecondPlayer = differenceSecondPlayer + (cardSecondPlayer - cardFirstPlayer);
    }
    else if(cardFirstPlayer == cardSecondPlayer)
    {
		cardFirstPlayer = int.Parse(Console.ReadLine());
		cardSecondPlayer = int.Parse(Console.ReadLine());
        if(cardFirstPlayer > cardSecondPlayer)
        {
            winner = nameFirstPlayer;
            difference = differenceFirstPlayer;
        }
        else if (cardFirstPlayer < cardSecondPlayer)
        {
            winner = nameSecondPlayer;
            difference = differenceSecondPlayer;
        }
        Console.WriteLine("Number wars!");
        Console.WriteLine($"{winner} is winner with {Math.Abs(difference)} points");
        break;
	}

	input = Console.ReadLine();

    if (input == "End of game")
    {
        continue;
    }

	cardSecondPlayer = int.Parse(Console.ReadLine());

}

if (input == "End of game")
{
    Console.WriteLine($"{nameFirstPlayer} has {differenceFirstPlayer} points");
    Console.WriteLine($"{nameSecondPlayer} has {differenceSecondPlayer} points");
}