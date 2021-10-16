namespace CoffeePattern.Condiments
{
    class Soy : CondimentDecorator
    {
        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            base.description = $"{beverage.GetDescription()} + Soy";
        }

        public override decimal Cost()
        {
            decimal cost = this.beverage.Cost() + 0.39M;
            return cost;
        }
    }
}