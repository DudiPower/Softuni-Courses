string typeProjection = Console.ReadLine();
int row=int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());

double price = 0;

if (typeProjection=="Premiere")
{
    price = 12.00;
}
else if(typeProjection == "Normal")
{
	price = 7.50;
}
else
{
	price = 5.00;
}

int numberPlaces = row * column;
double profit = numberPlaces * price;

Console.WriteLine("{0:f2} leva", profit);

