/*
100
2
1.0
2.0
3.0
=====
100
42
12.0
4.0
3.0
*/

internal class Program
{
	static void Main(string[] args)
	{
		double amountOfMoney = double.Parse(Console.ReadLine());
		int countStudents=int.Parse(Console.ReadLine());
		double priceOfLightsaber = double.Parse(Console.ReadLine());
		double priceOfRobe = double.Parse(Console.ReadLine());
		double priceOfBelt = double.Parse(Console.ReadLine());

		double priceLightsabers = priceOfLightsaber * (countStudents + Math.Ceiling(countStudents * 0.1));

		double priceRobes = countStudents * priceOfRobe;

		double freeBelts = Math.Floor(countStudents / 6.0);

		double priceBelts = (countStudents - freeBelts) * priceOfBelt;

		double totalSum = priceLightsabers + priceRobes + priceBelts;

		if (totalSum <= amountOfMoney)
		{
            Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {(totalSum - amountOfMoney):F2}lv more.");
        }
    }
}

