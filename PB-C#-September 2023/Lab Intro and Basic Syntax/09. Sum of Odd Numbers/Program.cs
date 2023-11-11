namespace _09._Sum_of_Odd_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countOdd=int.Parse(Console.ReadLine());
			int sum = 0;

			for (int i = 1; i <= countOdd; i++)
			{
				int currentNumber = i * 2 - 1;
				sum += currentNumber;
				Console.WriteLine(currentNumber);
			}

			Console.WriteLine($"Sum: {sum}");
		}
	}
}