using System;
using System.Collections.Generic;
using WeeklyFoodPlanner.Helpers;

namespace WeeklyFoodPlanner.Models
{
    /// <summary>
    /// Meals that can be placed on the Planner calendar of the week
    /// </summary>
    public class Meal : BaseEntity
    {
        /// <summary>
        /// Type of meal such as breakfast, lunch, dinner, or snack.
        /// </summary>
        public HelperEnums.MealType MealType { get; set; }

        /// <summary>
        /// Days of the week the meal should be listed under for the Planner
        /// </summary>
        public List<DayOfWeek> Days { get; set; }

        /// <summary>
        /// Link to the recipe for easy access to recipe and for creating grocery list based on quanitity
        /// </summary>
        public Recipe Recipe { get; set; }
    }
}