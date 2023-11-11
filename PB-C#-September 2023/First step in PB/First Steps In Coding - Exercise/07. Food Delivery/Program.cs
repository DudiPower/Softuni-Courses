int chickenMenu = int.Parse(Console.ReadLine());

int fishMenu = int.Parse(Console.ReadLine());

int vegetarianMenu = int.Parse(Console.ReadLine());

//•	Пилешко меню –  10.35 лв. 
//•	Меню с риба – 12.40 лв. 
//•	Вегетарианско меню  – 8.15 лв. 

double priceChickenMenu = chickenMenu * 10.35;
double priceFishMenu = fishMenu * 12.40;
double priceVegetarianMenu = vegetarianMenu * 8.15;

double price = priceChickenMenu + priceFishMenu + priceVegetarianMenu;

double dessert = 0.2 * price;

double finalPrice = price + dessert + 2.50;

Console.WriteLine(finalPrice);
