namespace _05._Messages
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int codeLength=int.Parse(Console.ReadLine());
			string finalword=string.Empty;
			int zero = 0;
			char word= '\0';

			for (int i = 1; i <= codeLength; i++)
			{
			
            	string currentNumber = Console.ReadLine();

				
			    int mainDigit = 0;
				int startInterval = 0;
				bool isZero = false;

				if (currentNumber[0] == '2')
					{
						mainDigit = 2;
					}
					 else if (currentNumber[0] == '3')
					{
						mainDigit = 3;
					}
					else if (currentNumber[0] == '4')
					{
						mainDigit = 4;
						
					}
					else if (currentNumber[0] == '5')
					{
						mainDigit = 5;
					}
					else if (currentNumber[0] == '6')
					{
						mainDigit = 6;
					}
					else if (currentNumber[0] == '7')
					{
						mainDigit = 7;
					}
					else if (currentNumber[0] == '8')
					{
						mainDigit = 8;
					}
					else if (currentNumber[0] == '9')
					{
						mainDigit = 9;
					}
					else if (currentNumber[0] == '0')
				    {
					zero = 32;
					isZero = true;
                    }

				if (isZero)
				{
					 word = (char)zero;
					finalword += word;
					continue;
				}


				if (mainDigit == 8 || mainDigit == 9 )
				{
					startInterval = (mainDigit - 2) * 3 + 1;
				}
				else
				{
					startInterval = (mainDigit - 2) * 3;
				}

				int letterIndex=startInterval + currentNumber.Length - 1;

				int letter = 97 + letterIndex;
				
				word=(char)letter;

				finalword += word;
                
            }
			Console.Write(finalword);
		}
	}
}