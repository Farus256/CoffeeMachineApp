namespace CoffeeMachineApp.Model
{
    public struct Cappuccino : IDrink
    {
        public int PaperCups => 1;
        public int Stirrers => 0;
        public int Straws => 1;
        public int CoffeePortions => 1;
        public int WaterPortions => 2;
        public int MilkPortions => 1;
        public int SugarPortions => 1;
        public decimal Price => 45m;
        public string Name => "Капучіно";
    }
}
