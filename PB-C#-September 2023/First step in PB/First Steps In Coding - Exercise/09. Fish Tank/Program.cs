int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

double percent = double.Parse(Console.ReadLine());

int capacity=length*width*height;

double capacityInDecimeters = capacity * 0.001;

double finalCapacity = capacityInDecimeters - capacityInDecimeters * (percent / 100);

Console.WriteLine(finalCapacity);
