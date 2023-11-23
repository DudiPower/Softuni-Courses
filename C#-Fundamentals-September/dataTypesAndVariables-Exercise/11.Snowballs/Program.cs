
internal class Program
	{
		static void Main(string[] args)
		{
			int numberSnowballs = int.Parse(Console.ReadLine());
			double highestSnowballValue = 0;
		    int snowForSnowball = 0;
		    int timeForSnowball = 0;
		    int qualitySnowball = 0;
		    double snowballValue = 0;
		    int highestSnowForSnowball = 0;
		    int highestTimeForSnowball = 0;
		    int highestQualitySnowball = 0;

			for (int i = 1; i <= numberSnowballs; i++)
			{
			     snowForSnowball = int.Parse(Console.ReadLine());
				 timeForSnowball = int.Parse(Console.ReadLine()) ;
				 qualitySnowball = int.Parse(Console.ReadLine());

				snowballValue = Math.Pow(snowForSnowball / (double)timeForSnowball, qualitySnowball);

				if (snowballValue >= highestSnowballValue)
				{
					highestSnowballValue = snowballValue;
				    highestSnowForSnowball = snowForSnowball;
				    highestTimeForSnowball = timeForSnowball;
				    highestQualitySnowball = qualitySnowball;
				}
			}

			Console.WriteLine($"{highestSnowForSnowball} : {highestTimeForSnowball} = {highestSnowballValue} ({highestQualitySnowball})");
	}
}

