using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WeeklyFoodPlanner.Models
{
    public class HelperEnums
    {
        public enum QuantityType
        {
            //[Description("")]
            Bags,
            Bottles,
            Blocks,
            Boxes,
            Cartons,
            Cups,
            Containers,
            Gallons,
            Liters,
            Ounces,
            Kilograms,
            Pounds,
            Tablespoons,
            Teaspoons
        };

        public enum MealType
        {
            Breakfast = 0,
            PreLunch = 1,
            Lunch = 2,
            SecondLunch = 3,
            Dinner = 4,
            PreWorkout = 5,
            PostWorkout = 6
        };

        public enum Tags
        {
            Breakfast,
            Snack,
            Lunch,
            Dinner,
            Dessert,
            PreWorkout,
            PostWorkout,
            Healthy,
            Keto,
            LowCarb,
            Salad,
            Meat,
            HighFiber,
            Filling,
            QuickPrep
        };
    }
}