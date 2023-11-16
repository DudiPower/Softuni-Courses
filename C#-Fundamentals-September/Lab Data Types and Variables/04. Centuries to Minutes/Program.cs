namespace _04._Centuries_to_Minutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    byte centuries = byte.Parse(Console.ReadLine());

			ushort years = (ushort)(centuries * 100);

			int days = (int)(years * 365.2422);

			int hours = days * 24;

			int minutes = hours * 60;

            Console.Write($"{centuries} centuries = ");
			Console.Write($"{years} years = ");
			Console.Write($"{days} days = ");	
			Console.Write($"{hours} hours = ");
			Console.Write($"{minutes} minutes");
        }
	}
}
