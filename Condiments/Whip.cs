namespace CoffeePattern.Condiments
{
    class Whip : CondimentDecorator
    {
        private Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            base.description = $"{beverage.GetDescription()} + Whip";
        }

        public override decimal Cost()
        {
            decimal cost = this.beverage.Cost() + 0.59M;
            return cost;
        }
    }
}