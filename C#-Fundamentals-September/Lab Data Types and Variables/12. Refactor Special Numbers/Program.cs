using System.ComponentModel.Design;

namespace _12._Refactor_Special_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countNumbers = int.Parse(Console.ReadLine());
			bool isSpecialNum = false;
			for (int i = 1; i <= countNumbers; i++)
			{
				int sum = 0;
				int lastNumber = 0;

				
					lastNumber += i % 10;
					int result = i / 10;
					sum += lastNumber + result;
				

			    isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine("{0} -> {1}", i , isSpecialNum);
				
			}

		}
	}
}
