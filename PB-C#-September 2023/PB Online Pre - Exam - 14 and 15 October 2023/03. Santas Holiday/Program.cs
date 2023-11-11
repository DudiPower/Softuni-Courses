int daysToStay=int.Parse(Console.ReadLine());
string typeRoom=Console.ReadLine();
string mark=Console.ReadLine();


int countNights = daysToStay - 1;
double priceRoom = 0;
double priceRoomWithMark = 0;

if (typeRoom == "apartment")
{
    priceRoom = countNights * 25;

	if (countNights < 10)
    {
        priceRoom = priceRoom - 0.3 * priceRoom;
    }
    else if (countNights >= 10 && countNights <= 15)
    {
		priceRoom = priceRoom - 0.35 * priceRoom;
	}
    else
    {
		priceRoom = priceRoom - 0.5 * priceRoom;
	}
}

else if (typeRoom == "president apartment")
{
	priceRoom = countNights * 35;

	if (countNights < 10)
	{
		priceRoom = priceRoom - 0.1 * priceRoom;
	}
	else if (countNights >= 10 && countNights <= 15)
	{
		priceRoom = priceRoom - 0.15 * priceRoom;
	}
	else
	{
		priceRoom = priceRoom - 0.2 * priceRoom;
	}
}

else
{
	priceRoom = countNights * 18;
}


if (mark == "positive")
{
	priceRoomWithMark = priceRoom + 0.25 * priceRoom;
}
else
{
	priceRoomWithMark = priceRoom - 0.1 * priceRoom;
}

Console.WriteLine($"{priceRoomWithMark:F2}");
