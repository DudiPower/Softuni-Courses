namespace _11._Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countOfOrders=int.Parse(Console.ReadLine());
			double totalPrice = 0;

			for (int i = 1; i <= countOfOrders; i++)
			{
				double pricePerCapsule=double.Parse(Console.ReadLine());
				int days=int.Parse(Console.ReadLine());
				int countCapsules=int.Parse(Console.ReadLine());

				double priceForCoffee = days * countCapsules * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${priceForCoffee:F2}");

                totalPrice += priceForCoffee;
			}

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
	}
}