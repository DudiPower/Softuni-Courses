namespace _02.sumDigits
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string number=Console.ReadLine();
			double sum = 0;

			for (int i = number.Length-1; i >=0; i--)
			{
				int currentNumber = int.Parse(number[i].ToString());
				sum += currentNumber;
			}
            Console.WriteLine(sum);
        }
	}
}
