namespace _09._Padawan_Equipment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double amountOfMoney=double.Parse(Console.ReadLine());
			int countOfStudents=int.Parse(Console.ReadLine());
            double priceForLightsaber=double.Parse(Console.ReadLine());
			double priceForRobe=double.Parse(Console.ReadLine());
			double priceForBelt=double.Parse(Console.ReadLine());

			double priceForAllLightsabers = Math.Ceiling(countOfStudents + 0.1 * countOfStudents) * priceForLightsaber;
			double priceForAllRobes=countOfStudents * priceForRobe;
			int countFreeBelts = countOfStudents / 6;
			double priceForAllBelts = (countOfStudents-countFreeBelts) * priceForBelt;

			double priceAllItems = priceForAllLightsabers + priceForAllRobes + priceForAllBelts;


			if (amountOfMoney >= priceAllItems)
			{
                Console.WriteLine($"The money is enough - it would cost {priceAllItems:F2}lv.");
            }
			else
			{
                Console.WriteLine($"John will need {priceAllItems - amountOfMoney:F2}lv more.");
            }
		}
	}
}