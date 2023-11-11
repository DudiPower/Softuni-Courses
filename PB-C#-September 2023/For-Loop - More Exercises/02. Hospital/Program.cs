int period = int.Parse(Console.ReadLine());

int unreviewedPatients = 0;
int reviewedPatients = 0;
int doctors = 7;

for (int i = 1;  i <= period; i++)
{
	int currentPatients=int.Parse(Console.ReadLine());

	if (i % 3 == 0)
	{
		if (unreviewedPatients > reviewedPatients)
		{
			doctors++;
		}
	}

	if (currentPatients>doctors)
	{
		unreviewedPatients =unreviewedPatients + (currentPatients - doctors);
		reviewedPatients += doctors;
	}
	else
	{
		reviewedPatients += currentPatients;
	}

}

Console.WriteLine("Treated patients: {0}.", reviewedPatients);
Console.WriteLine("Untreated patients: {0}.", unreviewedPatients);