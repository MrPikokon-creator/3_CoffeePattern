namespace CoffeePattern.Coffee
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            base.description = "Espresso";
        }

        public override decimal Cost()
        {
            return 1.29M;
        }
    }
}