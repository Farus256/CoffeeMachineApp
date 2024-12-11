namespace CoffeeMachineApp.Model
{
    public struct Americano : IDrink
    {
        public int PaperCups => 1;
        public int Stirrers => 1;
        public int Straws => 0;
        public int CoffeePortions => 1;
        public int WaterPortions => 2;
        public int MilkPortions => 0;
        public int SugarPortions => 1;
        public decimal Price => 38m;
        public string Name => "Амерікано";
    }
}
