int numberMovies=int.Parse(Console.ReadLine());

string nameMovie = string.Empty;
double ratingMovie = 0;
double sumRating = 0;
double minRating = double.MaxValue;
double maxRating = double.MinValue;
string goodMovie=string.Empty;
string badMovie=string.Empty;

for (int i=1; i <= numberMovies; i++)
{

	nameMovie = Console.ReadLine();
	ratingMovie = double.Parse(Console.ReadLine());

	sumRating += ratingMovie;

	if (ratingMovie > maxRating)
	{
		maxRating = ratingMovie;
		goodMovie= nameMovie;
	}
	else if (ratingMovie < minRating)
	{
		minRating = ratingMovie;
		badMovie = nameMovie;
	}

}

double averageRating= sumRating / numberMovies;

Console.WriteLine($"{goodMovie} is with highest rating: {maxRating:F1}");
Console.WriteLine($"{badMovie} is with lowest rating: {minRating:F1}");
Console.WriteLine($"Average rating: {averageRating:F1}");

