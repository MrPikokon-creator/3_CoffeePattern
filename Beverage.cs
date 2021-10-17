namespace CoffeePattern
{
    class Beverage
    {
        protected string description = string.Empty;

        public virtual decimal Cost()
        {
            return 0M;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
