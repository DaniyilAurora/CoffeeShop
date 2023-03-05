namespace CoffeeShop.Entities;

class CoffeeSale
{
    string Type { get; set; } = String.Empty;
    float Price { get; set; }
    int Amount { get; set; }
    DateTime Date { get; set; } = DateTime.Now;
}