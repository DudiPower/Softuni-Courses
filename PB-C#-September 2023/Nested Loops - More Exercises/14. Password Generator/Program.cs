int n=int.Parse(Console.ReadLine());
int l=int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{

	for (int j = 1; j <= n; j++)
	{
		

		
		
			

				for (int a = 97; a < 97 + l; a++)
				{
					char character1 = (char)a;

					for (int b = 97; b < 97 + l; b++)
					{
						char character2 = (char)b;

				        for (int k = 1; k <= n; k++)
				        {
					       if (k > i && k > j)
					       {
						       Console.Write($"{i}{j}{character1}{character2}{k} ");
					       }
				        }
                    }

				}

			
	}
	    
}



