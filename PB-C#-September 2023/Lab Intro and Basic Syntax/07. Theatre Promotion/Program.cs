namespace _07._Theatre_Promotion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string typeDay=Console.ReadLine();
			int age=int.Parse(Console.ReadLine());
			int ticketPrice = 0;
			bool isCorrect = true;

			if (typeDay == "Weekday")
			{
				if (age >=0 && age<=18)
				{
					ticketPrice = 12;
				}
                else if(age>18 && age<=64)
                {
					ticketPrice = 18;
				}
				else if (age>64 && age<=122)
				{
					ticketPrice = 12;
				}
				else
				{
					isCorrect = false;
					Console.WriteLine("Error!");
				}
			}
			else if (typeDay == "Weekend")
			{
				if (age >= 0 && age <= 18)
				{
					ticketPrice = 15;
				}
				else if (age > 18 && age <= 64)
				{
					ticketPrice = 20;
				}
				else if (age > 64 && age <= 122)
				{
					ticketPrice = 15;
				}
				else
				{
					isCorrect = false;
					Console.WriteLine("Error!");
				}
			}
			else
			{
				if (age >= 0 && age <= 18)
				{
					ticketPrice = 5;
				}
				else if (age > 18 && age <= 64)
				{
					ticketPrice = 12;
				}
				else if (age > 64 && age <= 122)
				{
					ticketPrice = 10;
				}
				else
				{
					isCorrect = false;
					Console.WriteLine("Error!");
				}
			}

			if (isCorrect)
			{
                Console.WriteLine($"{ticketPrice}$");
            }
		}
	}
}