using System;
using System.Collections.Generic;

namespace WeeklyFoodPlanner.Models
{
    public class HelperEnums
    {
        public enum QuantityType
        {
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
            Breakfast,
            Snack1,
            Lunch,
            Snack2,
            Dinner,
            PreWorkout,
            PostWorkout
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