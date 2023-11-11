namespace _11._Multiplication_Table_2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int interval=int.Parse(Console.ReadLine());

			for (int i = interval; i <= 10; i++)
			{
				Console.WriteLine($"{number} X {i} = {number * i}");
			}

			if (interval > 10 )
			{
				Console.WriteLine($"{number} X {interval} = {number * interval}");
			}
		}
	}
}