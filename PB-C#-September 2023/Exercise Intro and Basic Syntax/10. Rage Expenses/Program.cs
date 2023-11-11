namespace _10._Rage_Expenses
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int countLostGames=int.Parse(Console.ReadLine());
			double priceHeadset=double.Parse(Console.ReadLine());
			double priceMouse=double.Parse(Console.ReadLine());
			double priceKeyboard=double.Parse(Console.ReadLine());
			double priceDisplay=double.Parse(Console.ReadLine());
			double neededMoney = 0;

			for (int i = 1; i <= countLostGames; i++)
			{

				if (i % 12 ==0)
				{
					neededMoney += priceDisplay;
				}

				if (i % 6 == 0)
				{
					neededMoney += priceKeyboard;
				}

				if (i % 3 == 0)
				{
					neededMoney += priceMouse;
				}

				if (i % 2 == 0)
				{
					neededMoney += priceHeadset;
				}
			}

            Console.WriteLine($"Rage expenses: {neededMoney:F2} lv.");
        }
	}
}