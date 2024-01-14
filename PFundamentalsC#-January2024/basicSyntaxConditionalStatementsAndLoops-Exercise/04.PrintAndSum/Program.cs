/*
0
26

===
50
60

==== 
5
10

*/
internal class Program
{
	static void Main(string[] args)
	{
		int startNumber = int.Parse(Console.ReadLine());
		int endNumber = int.Parse(Console.ReadLine());
		int sum = 0;

		for (int i = startNumber; i <= endNumber; i++)
		{
            Console.Write($"{i} ");
			sum += i;
        }
        Console.WriteLine();
        Console.Write($"Sum: {sum}");
    }
}

