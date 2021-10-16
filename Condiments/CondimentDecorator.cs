namespace CoffeePattern.Condiments
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract override decimal Cost();
    }
}