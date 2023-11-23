namespace _08.BeerKegs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countBeerKegs = int.Parse(Console.ReadLine());
			string modelBiggestKeg = "";
			double volumeBiggestKeg = 0;

			for (int i = 0; i < countBeerKegs; i++)
			{
				 string modelKeg = Console.ReadLine();
				 double radiusKeg = double.Parse(Console.ReadLine());
				 int heightKeg = int.Parse(Console.ReadLine());
				 
                 double volume = Math.PI * Math.Pow(radiusKeg, 2) * heightKeg;

				if (volume > volumeBiggestKeg)
				{
					volumeBiggestKeg = volume;
					modelBiggestKeg = modelKeg;
				}
			}

			Console.WriteLine(modelBiggestKeg);
		}
	}
}
