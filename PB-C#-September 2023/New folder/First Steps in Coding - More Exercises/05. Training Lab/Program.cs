double lengthHall = double.Parse(Console.ReadLine());

double widthHall = double.Parse(Console.ReadLine());

double lengthHallCentimeters = lengthHall * 100;
double widthHallCentimeters = widthHall * 100;

double widthWithoutCoridor = widthHallCentimeters - 100;

int desksOnRow = (int)widthWithoutCoridor / 70;

int numbersRow = (int)lengthHallCentimeters / 120;

int numberSeats = numbersRow * desksOnRow - 3;

Console.WriteLine(numberSeats);