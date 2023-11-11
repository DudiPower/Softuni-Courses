using System.Text;

int amountVoucher = int.Parse(Console.ReadLine());

string purchase=Console.ReadLine();
int price = 0;
int moviesCount = 0;
int othersCount = 0;

while(purchase != "End")
{

	if (purchase.Length > 8)
	{	

		price = (int)purchase[0] + (int)purchase[1]; 
	}

	else
	{

		price = (int)purchase[0];
	}


	if (amountVoucher >= price)
	{
		amountVoucher = amountVoucher - price;

		if (purchase.Length > 8)
		{
			moviesCount++;
		}
		else
		{
			othersCount++;
		}
	}
	else
	{
		Console.WriteLine(moviesCount);
		Console.WriteLine(othersCount);
		break;
	}


	purchase = Console.ReadLine();
}

if (purchase == "End")
{
	Console.WriteLine(moviesCount);
	Console.WriteLine(othersCount);
}
	