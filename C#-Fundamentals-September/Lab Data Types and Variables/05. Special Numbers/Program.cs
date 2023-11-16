namespace _05._Special_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number=int.Parse(Console.ReadLine());

			for (int i = 1; i <= number; i++)
			{
				bool isSpecial = false;
				int sum = 0;

                Console.Write($"{i} -> ");

				int lastDigit = i % 10;
				int result = i / 10;
				sum += lastDigit + result;


                if (sum == 5 || sum == 7 || sum == 11)
				{
					isSpecial = true;
                    Console.WriteLine(isSpecial);
                }
				else
				{
					Console.WriteLine(isSpecial);
				}
			}
		}
	}
}
