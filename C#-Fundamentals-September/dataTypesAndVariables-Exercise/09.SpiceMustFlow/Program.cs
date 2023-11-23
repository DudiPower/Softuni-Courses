
internal class Program
{
     static void Main(string[] args)
	 {
		int yield = int.Parse(Console.ReadLine());
		int days = 0;
		int totalExtractSpice = 0;

		while (yield >= 100)
		{
			days++;
			int extractSpice = yield - 26;
			totalExtractSpice += extractSpice;
			yield -= 10;
		}

		if (totalExtractSpice > 26)
		{
			totalExtractSpice -= 26;
		}

		Console.WriteLine(days);
		Console.WriteLine(totalExtractSpice);


	}
}

