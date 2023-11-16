namespace _03._Exact_Sum_of_Real_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countNumbers=int.Parse(Console.ReadLine());
			decimal sum = 0;

			for (int i = 1; i <= countNumbers; i++)
			{
				decimal currentNumber = decimal.Parse(Console.ReadLine());

				sum += currentNumber;
			}
			Console.WriteLine(sum);
		}
	}
}
