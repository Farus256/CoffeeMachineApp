namespace CoffeeMachineApp.Model
{
    public interface IDrink
    {
        int PaperCups { get; }
        int Stirrers { get; }
        int Straws { get; }
        int CoffeePortions { get; }
        int WaterPortions { get; }
        int MilkPortions { get; }
        int SugarPortions { get; }
        decimal Price { get; }
        string Name { get; }
    }
}
