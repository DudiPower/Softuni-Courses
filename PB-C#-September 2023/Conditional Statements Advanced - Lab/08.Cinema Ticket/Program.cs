string day=Console.ReadLine();

//switch (day)
//{
//	case "Monday":
//	case "Tuesday":
//	case "Friday":
//		Console.WriteLine(12);
//		break;
//	case "Wednesday":
//	case "Thursday":
//		Console.WriteLine(14);
//		break;	
//	default:
//		Console.WriteLine(16);
//		break;
//}

if (day=="Monday" || day=="Tuesday" || day == "Friday")
{
	Console.WriteLine(12);
}
else if (day == "Wednesday" || day == "Thursday")
{
	Console.WriteLine(14);
}
else
{
	Console.WriteLine(16);
}
