string searchBook=Console.ReadLine();

string book=Console.ReadLine();
int numberBooks = 0;

while (book != "No More Books")
{

	if (book == searchBook)
	{
		Console.WriteLine($"You checked {numberBooks} books and found it.");
		break;
	}

	numberBooks++;

	book = Console.ReadLine();

}

if (book == "No More Books")
{
	Console.WriteLine("The book you search is not here!");
	Console.WriteLine($"You checked {numberBooks} books.");
}
