int countWrappingPaper=int.Parse(Console.ReadLine());
int countCloth=int.Parse(Console.ReadLine());
double litresGlue=double.Parse(Console.ReadLine());
int percentDiscount=int.Parse(Console.ReadLine());

double priceWrappingPaper = countWrappingPaper * 5.80;
double priceCloth = countCloth * 7.20;
double priceGlue = litresGlue * 1.20;

double priceMaterials=priceWrappingPaper+priceCloth+priceGlue;

double priceWithDiscount = priceMaterials - (percentDiscount/100.0) * priceMaterials;

Console.WriteLine($"{priceWithDiscount:F3}"); 
