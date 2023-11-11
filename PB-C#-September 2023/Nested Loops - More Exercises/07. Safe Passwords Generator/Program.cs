int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());	
int maxCountPasswords=int.Parse(Console.ReadLine());
int count = 0;
bool isTrue = false;
int countX = 1;
int countY = 1;
bool noMoreCombination=false;

for (char i = '"'; i <= '7';)
{ 	
	
  for (char j = '?'; j <= '`';)
  {
     
		for (int x = 1; x <= countX ; x++)
		{
			isTrue=true;
			for (int y = 1; y <= countY; y++)
			{
				j++;
				i++;

				count++;
				if (count > maxCountPasswords)
				{
					noMoreCombination = true;
					break;
				}
				Console.Write($"{i}{j}{x}{y}{j}{i}|");

				countY++;

				if (countY>b)
				{
					countY = 1;
					break;
				}
			}
			if (noMoreCombination)
			{
				break;
			}


			countX++;
			if (countX > a)
			{

				break;
			}
		}
		if (noMoreCombination)
		{
			break;
		}
		if (isTrue)
		{
			break;
		}
		
  }
	if (noMoreCombination)
	{
		break;
	}
	if (isTrue)
	{
		break;
	}

}
		
	
	

	


