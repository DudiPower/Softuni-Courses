namespace Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			float floatPI = 3.141592653589793238f;
			double doublePI = 3.1415926535897932382412341241555;
			decimal decimalPI = 3.1415926535897932382412341241555m;
			Console.WriteLine("Float PI is: {0}", floatPI);
			Console.WriteLine("Double PI is: {0}", doublePI);
			Console.WriteLine("Decimal PI is: {0}", decimalPI);
		}
	}
}