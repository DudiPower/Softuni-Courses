int yearCharge = int.Parse(Console.ReadLine());

double shoes = yearCharge - 0.4 * yearCharge;

double outfit = shoes - 0.2 * shoes;

double ball = outfit / 4;

double accessories = ball / 5;

double finalCharge = yearCharge + shoes + outfit + ball + accessories;

Console.WriteLine(finalCharge);
