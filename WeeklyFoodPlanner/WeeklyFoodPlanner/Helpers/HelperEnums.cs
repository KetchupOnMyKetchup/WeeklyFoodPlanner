using System;
using System.Collections.Generic;
using System.ComponentModel;
using SQLite;

namespace WeeklyFoodPlanner.Helpers
{
    /// <summary>
    /// Helper Enums for the Food Planner
    /// </summary>
    public class HelperEnums
    {
        /// <summary>
        /// Type of measurement quantities
        /// Should be stored as text in SQLite
        /// </summary>
        [StoreAsText]
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

        /// <summary>
        /// Meals of the day
        /// Should be stored as text in SQLite
        /// </summary>
        [StoreAsText]
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

        /// <summary>
        /// Tags for filtering, sorting, and categorizing recipes
        /// Should be stored as text in SQLite
        /// </summary>
        [StoreAsText]
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