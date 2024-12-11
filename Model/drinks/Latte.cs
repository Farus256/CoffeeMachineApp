namespace CoffeeMachineApp.Model
{
    public struct Latte : IDrink
    {
        public int PaperCups => 1;
        public int Stirrers => 0;
        public int Straws => 1;
        public int CoffeePortions => 1;
        public int WaterPortions => 2;
        public int MilkPortions => 2;
        public int SugarPortions => 1;
        public decimal Price => 48m;
        public string Name => "Лате";
    }
}
