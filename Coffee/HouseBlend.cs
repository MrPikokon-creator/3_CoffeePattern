namespace CoffeePattern.Coffee
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            base.description = "HouseBlend";
        }

        public override decimal Cost()
        {
            return 2.49M;
        }
    }
}