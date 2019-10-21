using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food> {};
        }

        public bool isFull {

            get{
                if (calorieIntake > 1200)
                {
                return true ;
                }
                else
                {
                    return false;
                }
            }
            
            
            set{;}}



        // add a public "getter" property called "IsFull"

        // build out the Eat method{get;set;}
        public void Eat(Food item)
        {
            if (isFull == false)
            {
                calorieIntake += item.Calories;
                Console.WriteLine(item.Name);
                Console.WriteLine(item.IsSpicy);
                Console.WriteLine(item.IsSweet);
                FoodHistory.Add(item);
                Console.WriteLine(FoodHistory[0].Name);
            }
            else
            {
                Console.WriteLine("Stop eating you fat pig");
            }


        }
    }
}
// add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
// add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
// build out the Eat method that: if the Ninja is NOT full
// adds calorie value to ninja's total calorieIntake
// adds the randomly selected Food object to ninja's FoodHistory list
// writes the Food's Name - and if it is spicy/sweet to the console
// if the Ninja IS full
// issues a warning to the console that the ninja is full and cannot eat anymore