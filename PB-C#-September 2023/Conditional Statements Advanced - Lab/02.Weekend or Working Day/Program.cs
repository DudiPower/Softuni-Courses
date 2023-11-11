string day=Console.ReadLine();

switch (day)
{
	case "Monday":
	case "Tuesday":
	case "Wednesday":
	case "Thursday":
	case "Friday":
		Console.WriteLine("Working day");
		break;
	case "Saturday":
	case "Sunday":
		Console.WriteLine("Weekend");
		break;
	default:
		Console.WriteLine("Error");
		break;
}

if (day=="Monday" || day=="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday")
{
	Console.WriteLine("Working day");
}
else if (day=="Saturday" || day=="Sunday")
{
	Console.WriteLine("Weekend");
}
else
{
	Console.WriteLine("Error");
}