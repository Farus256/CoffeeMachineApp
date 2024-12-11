namespace CoffeeMachineApp.Model
{
    public class ResourceStorage
    {
        public int PaperCups { get; set; }
        public int Stirrers { get; set; }
        public int Straws { get; set; }
        public int Coffee { get; set; }
        public int Sugar { get; set; }
        public int Water { get; set; }
        public int Milk { get; set; }

        public ResourceStorage(int paperCups, int stirrers, int straws, int coffee, int sugar, int water, int milk)
        {
            PaperCups = paperCups;
            Stirrers = stirrers;
            Straws = straws;
            Coffee = coffee;
            Sugar = sugar;
            Water = water;
            Milk = milk;
        }

        public void Replenish(int paperCups, int stirrers, int straws, int coffee, int sugar, int water, int milk)
        {
            PaperCups += paperCups;
            Stirrers += stirrers;
            Straws += straws;
            Coffee += coffee;
            Sugar += sugar;
            Water += water;
            Milk += milk;
        }

        public bool DeductResources(int paperCups, int stirrers, int straws, int coffee, int sugar, int water, int milk)
        {
            if (PaperCups < paperCups || Stirrers < stirrers || Straws < straws ||
                Coffee < coffee || Sugar < sugar || Water < water || Milk < milk)
                return false;

            PaperCups -= paperCups;
            Stirrers -= stirrers;
            Straws -= straws;
            Coffee -= coffee;
            Sugar -= sugar;
            Water -= water;
            Milk -= milk;
            return true;
        }

        public override string ToString()
        {
            return $"Паперові стакани: {PaperCups}, Палички для цукру: {Stirrers}, Трубочки: {Straws}, Кава: {Coffee}, Цукор: {Sugar}, Вода: {Water}, Молоко: {Milk}";
        }
    }
}
