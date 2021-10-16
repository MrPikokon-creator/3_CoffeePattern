namespace CoffeePattern.Condiments
{
    class Mocha : CondimentDecorator
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            base.description = $"{beverage.GetDescription()} + Mocha";
        }

        public override decimal Cost()
        {
            decimal cost = this.beverage.Cost() + 0.39M;
            return cost;
        }
    }
}