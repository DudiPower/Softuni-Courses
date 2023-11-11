int n = int.Parse(Console.ReadLine());
int sum = 0;
int mulplication = 0; 
bool isFind = false;

for (int a = 1; a <= 9; a++)
{
	for (int b = 9; b >= a; b--)
	{
		for (int c = 0; c <= 9; c++)
		{
			for(int d = 9; d >= c; d--)
			{
				sum = a + b + c + d;
				mulplication = a * b * c * d;

				if (sum == mulplication && n % 10 == 5)
				{
                    Console.WriteLine($"{a}{b}{c}{d}");
					isFind = true;
					break;
                }

				else if (mulplication/sum == 3 && n % 3 == 0)
				{
					Console.WriteLine($"{d}{c}{b}{a}");
					isFind = true;
					break;
				}


			}

			if (isFind)
			{
				break;
			}
		}
		if (isFind)
		{
			break;
		}
	}
	if (isFind)
	{
		break;
	}
}

if (!isFind)
{
	Console.WriteLine("Nothing found");
}
