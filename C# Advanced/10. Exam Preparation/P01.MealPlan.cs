using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.PlanMeal_WithStackAndQueue
{
    class StartUP
    {
        static void Main(string[] args)
        {
            string[] meal = Console.ReadLine().Split();
            int[] dayCal = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<string> typeMeal = new Queue<string>(meal);
            Stack<int> dayCalories = new Stack<int>(dayCal);

            Dictionary<string, int> mealCalÍnfo = new Dictionary<string, int>()
            {
                { "salad", 350},
                { "soup", 490},
                { "pasta", 680},
                { "steak", 790}
            };

            int numberOfMeal = typeMeal.Count;
            int mealCount = 0;
            bool isEnd = false;
            int bufferCal = 0;


            while (true)
            {
                if (dayCalories.Count == 0)
                {
                    Console.WriteLine($"John ate enough, he had {mealCount} meals.");
                    Console.WriteLine($"Meals left: {string.Join(", ", typeMeal)}.");
                    break;
                }

                int currentDayCalories = dayCalories.Pop();
                if (bufferCal != 0)
                {
                    currentDayCalories -= bufferCal;
                    bufferCal = 0;
                }


                while (true)
                {
                    if (typeMeal.Count == 0)
                    {
                        dayCalories.Push(currentDayCalories);
                        Console.WriteLine($"John had {numberOfMeal} meals.");
                        Console.WriteLine($"For the next few days, he can eat {string.Join(", ", dayCalories)} calories.");
                        isEnd = true;
                        break;
                    }
                    mealCount++;
                    string dayMeal = typeMeal.Dequeue();
                    int dayMealCal = mealCalÍnfo[dayMeal];

                    currentDayCalories -=dayMealCal;

                    if (currentDayCalories <= 0)
                    {
                        bufferCal = Math.Abs(0 - currentDayCalories);
                        break;
                    }
                }
                if (isEnd)
                {
                    break;
                }
            }           
        }
    }
}
