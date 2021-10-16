using System;
using CoffeePattern.Coffee;
using CoffeePattern.Condiments;

namespace CoffeePattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите напиток");
            Console.WriteLine("1. House Blend");
            Console.WriteLine("2. Dark Roast");
            Console.WriteLine("3. Decaf");
            Console.WriteLine("4. Espresso");
            Console.Write("Выбор (цифра): ");
            string beverageId = Console.ReadLine();
            Beverage beverage = null;

            if (beverageId == "1")
            {
                beverage = new HouseBlend();
            }
            else if (beverageId == "2")
            {
                beverage = new DarkRoast();
            }
            else if (beverageId == "3")
            {
                beverage = new Decaf();
            }
            else if (beverageId == "4")
            {
                beverage = new Espresso();
            }

            while (true)
            {
                Console.WriteLine("\nВыберите добавку");
                Console.WriteLine("1. Milk");
                Console.WriteLine("2. Soy");
                Console.WriteLine("3. Mocha");
                Console.WriteLine("4. Whip");
                Console.WriteLine("Enter - выбрать");
                Console.Write("Выбор (цифра): ");
                string condimentId = Console.ReadLine();

                if (condimentId == "1")
                {
                    beverage = new Milk(beverage);
                    continue;
                }
                else if (condimentId == "2")
                {
                    beverage = new Soy(beverage);
                }
                else if (condimentId == "3")
                {
                    beverage = new Mocha(beverage);
                }
                else if (condimentId == "4")
                {
                    beverage = new Whip(beverage);
                }
                else
                {
                    Console.WriteLine($"\nОписание: {beverage.GetDescription()}");
                    Console.WriteLine($"Стоимость: {beverage.Cost()}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}