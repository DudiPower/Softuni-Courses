namespace _01.IntegerOperations
{

	/*
	10
	20
	3
	3
	======
	15
    14
    2
    3

	*/
	internal class Program
	{
		static void Main(string[] args)
		{
		    int firstNumber=int.Parse(Console.ReadLine());
			int secondNumber=int.Parse(Console.ReadLine());
			int thirdNumber=int.Parse(Console.ReadLine());
			int fourthNumber=int.Parse(Console.ReadLine());

			int addProccess = firstNumber + secondNumber;
			int divideProcces = addProccess / thirdNumber;
			int multipleProcces = divideProcces * fourthNumber;

			Console.WriteLine(multipleProcces);
		}
	}
}
