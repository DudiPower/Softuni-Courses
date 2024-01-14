/*
Acer
login
go
let me in
recA

====
momo
omom

=====
sunny
rainy
cloudy
sunny
not sunny

*/
internal class Program
{
	static void Main(string[] args)
	{
		string username = Console.ReadLine();
		string password = string.Join("", username.Reverse());

		int attempt = 0;

		while (attempt < 4)
		{
			attempt++;

			string tryLogin = Console.ReadLine();

			if (tryLogin == password)
			{
                Console.WriteLine($"User {username} logged in.");
				break;
            }

			if (attempt == 4)
			{
				Console.WriteLine($"User {username} blocked!");
				break;
			}

            Console.WriteLine("Incorrect password. Try again.");
        }

	}
}

