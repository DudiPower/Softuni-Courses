namespace _04._Print_and_sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int startSequance=int.Parse(Console.ReadLine());
			int endSequance=int.Parse(Console.ReadLine());
			int sum = 0;

			for (int i = startSequance; i <= endSequance; i++)
			{
				Console.Write(i + " ");
				sum += i;

			}

			Console.WriteLine();
			Console.WriteLine($"Sum: {sum}");
		}
	}
}