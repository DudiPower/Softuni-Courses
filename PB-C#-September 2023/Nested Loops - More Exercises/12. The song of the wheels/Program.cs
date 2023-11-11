int controlNumber=int.Parse(Console.ReadLine());
int counter = 0;
string fourthNumber = "";
bool isFind=false;
string number = "";


for (int a = 1; a <= 9; a++)
{

	for (int b = 1; b <= 9; b++)
	{
		
		for (int c = 1; c <= 9; c++)
		{

			for(int d = 1; d <= 9; d++)
			{
				

				if (a < b )
				{

					if (c > d)
					{
						if (a * b + c * d == controlNumber)
						{
							counter++;

                            number = $"{a}{b}{c}{d} ";
							Console.Write(number);

                            if (counter == 4)
							{
								fourthNumber = $"{a}{b}{c}{d}";
								isFind = true;
							}
                        }
					}

				}
			}
		}
	}
}

if (isFind)
{
	Console.WriteLine();
	Console.WriteLine($"Password: {fourthNumber}");
}
else if(isFind ==false)
{
	Console.WriteLine();
	Console.WriteLine("No!");
}
