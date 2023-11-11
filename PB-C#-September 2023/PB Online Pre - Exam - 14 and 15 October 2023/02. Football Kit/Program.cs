double priceTShirt=double.Parse(Console.ReadLine());
double sumToWinBall=double.Parse(Console.ReadLine());

double priceShorts = 0.75 * priceTShirt;
double priceSocks = 0.2 * priceShorts;
double priceSneakers = 2 * (priceTShirt + priceShorts);

double priceEquipmentsDiscount=(priceTShirt + priceShorts + priceSocks + priceSneakers) - 0.15* (priceTShirt + priceShorts + priceSocks + priceSneakers);

if (priceEquipmentsDiscount >=sumToWinBall)
{
	Console.WriteLine("Yes, he will earn the world-cup replica ball!");
	Console.WriteLine($"His sum is {priceEquipmentsDiscount:F2} lv.");
}
else
{
	Console.WriteLine("No, he will not earn the world-cup replica ball.");
	Console.WriteLine($"He needs {sumToWinBall-priceEquipmentsDiscount:F2} lv. more.");
}

