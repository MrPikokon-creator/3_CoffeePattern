namespace CoffeePattern.Coffee
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            base.description = "Decaf";
        }

        public override decimal Cost()
        {
            return 1.79M;
        }
    }
}