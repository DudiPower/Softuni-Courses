/*
5
20
100
100
100
20

*/
internal class Program
	{
		static void Main(string[] args)
		{
			int numberLines=int.Parse(Console.ReadLine());
			int sumLitres = 0;

			for (int i = 0; i < numberLines; i++)
			{

				int litres=int.Parse(Console.ReadLine());

			    sumLitres += litres;

			    if (sumLitres > 255)
				{
				     sumLitres -= litres;
				     Console.WriteLine("Insufficient capacity!");
                }
			
		    }
			   Console.WriteLine(sumLitres);
		}
	}

