namespace CoffeePattern.Condiments
{
    class Milk : CondimentDecorator
    {
        private Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            base.description = $"{beverage.GetDescription()} + Milk";
        }

        public override decimal Cost()
        {
            decimal cost = this.beverage.Cost() + 0.29M;
            return cost;
        }
    }
}