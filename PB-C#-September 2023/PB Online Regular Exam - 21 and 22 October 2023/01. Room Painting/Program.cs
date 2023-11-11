int countBoxPaint=int.Parse(Console.ReadLine());
int countRollsWallpapers=int.Parse(Console.ReadLine());
double priceForPairGloves=double.Parse(Console.ReadLine());
double priceForBrush=double.Parse(Console.ReadLine());

double pricePaint = countBoxPaint * 21.50;
double priceRollsWallpapers = countRollsWallpapers * 5.20;

double countGloves = Math.Ceiling(0.35 * countRollsWallpapers);
double countBrushes = Math.Floor(0.48 * countBoxPaint);

double priceGloves = countGloves * priceForPairGloves;
double priceBrushes = countBrushes* priceForBrush;

double allPrice = pricePaint + priceRollsWallpapers + priceGloves + priceBrushes;

double delivery = 1.0 / 15 * allPrice;

Console.WriteLine($"This delivery will cost {delivery:F2} lv.");