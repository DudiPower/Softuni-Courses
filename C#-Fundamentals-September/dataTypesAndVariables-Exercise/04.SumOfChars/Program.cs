/*
5
A
b
C
d
E
======
12
S
o
f
t
U
n
i
R
u
l
z
z
*/
internal class Program
	{
		static void Main(string[] args)
		{
			int numberLines=int.Parse(Console.ReadLine());
			int sumOfLetters = 0;

			for (int i = 0; i < numberLines; i++)
			{
				char letter = char.Parse(Console.ReadLine());

				sumOfLetters += letter;
			}

        Console.WriteLine($"The sum equals: {sumOfLetters}");
        }
	}

