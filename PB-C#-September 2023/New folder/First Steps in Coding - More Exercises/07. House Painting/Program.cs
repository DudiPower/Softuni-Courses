double heightHouse=double.Parse(Console.ReadLine());
double lengthSidewall=double.Parse(Console.ReadLine());
double heightTriangleSideRoof=double.Parse(Console.ReadLine());

double frontWall = heightHouse * heightHouse - (1.2*2);
double backWall = heightHouse * heightHouse;

double sideWalls = 2 * (heightHouse*lengthSidewall-(1.5*1.5));

double roof = 2 * (heightHouse * lengthSidewall) + 2*((heightHouse * heightTriangleSideRoof)/2);

double allWalls = frontWall + backWall + sideWalls;

double litresGreenPaint = allWalls / 3.4;

double litresRedPaint = roof / 4.3;

Console.WriteLine("{0:0.00}",litresGreenPaint);
Console.WriteLine("{0:0.00}",litresRedPaint);

