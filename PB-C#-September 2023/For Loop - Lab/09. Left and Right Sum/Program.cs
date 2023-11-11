int n=int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < n; i++)
{
	int currentNumber = int.Parse(Console.ReadLine());

	leftSum += currentNumber;

}

for (int i = 0; i < n; i++)
{
	int currentNumber = int.Parse(Console.ReadLine());

	rightSum += currentNumber;
}

if (leftSum == rightSum)
{
	Console.WriteLine("Yes, sum = " + leftSum);
}
else
{
	Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
}

//int counter = 0;

//for (int i = 1; i <= 2 * n; i++)
//{
//	int currentNumber = int.Parse(Console.ReadLine());


//	if (i<=n) 
//	{ 
//	leftSum += currentNumber;
//    }  
//	if (i>n)
//	{
//		rightSum += currentNumber;
//	}
//}

//if (leftSum == rightSum)
//{
//	Console.WriteLine("Yes, sum = " + leftSum);
//}
//else
//{
//	Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
//}