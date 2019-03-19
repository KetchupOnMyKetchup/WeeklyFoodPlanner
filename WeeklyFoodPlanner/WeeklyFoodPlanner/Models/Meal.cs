using System;
using System.Collections.Generic;

namespace WeeklyFoodPlanner.Models
{
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