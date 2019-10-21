using System;
using System.Collections.Generic;


namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
            new Food("Eggs", 1030, false, true),
            new Food("Cheese", 1600, true, false),
            new Food("Milk", 1036, false, true),
            new Food("Bread", 1060, false, false),
            new Food("Coffee", 1300, true, true),
            new Food("Pepper", 3100, false, false),
            new Food("Salt", 1630, false, true),
            new Food("Rice", 1030, false, false),
            new Food("Chicken", 1300, true, true),
            new Food("Meat", 1630, false, false),
            };
        }
    public Food Serve()
    {
        Random rand = new Random();
        int theRand = rand.Next(1, Menu.Count);
        Console.WriteLine(theRand);
        Console.WriteLine(Menu[theRand].Name);
        return Menu[theRand];
    }

}
}