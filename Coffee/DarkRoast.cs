namespace CoffeePattern.Coffee
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            base.description = "DarkRoast";
        }

        public override decimal Cost()
        {
            return 1.49M;
        }
    }
}