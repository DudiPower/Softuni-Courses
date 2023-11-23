namespace _03.elelvator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfPeople=int.Parse(Console.ReadLine());
			int capacityElevator=int.Parse(Console.ReadLine());

			if (numberOfPeople <= capacityElevator)
			{
                Console.WriteLine(1);
                
            }
			else
			{
				int fullCourses = numberOfPeople / capacityElevator;
                
                if (numberOfPeople % capacityElevator != 0)
				{
					int courses = (int)Math.Ceiling((double)numberOfPeople / capacityElevator);
					Console.WriteLine(courses);
				}
				else
				Console.WriteLine(fullCourses);
			}
			
		}
	}
}
