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
        /// First day of the week the meal will be eaten. 0 = Sunday, 1 = Monday, etc.
        /// </summary>
        
        public int StartDay { get; set; }
        /// <summary>
        /// Number of days to repeat the meal
        /// </summary>
        public int NumberDaysToRepeat { get; set; }

        /// <summary>
        /// Link to the recipe for easy access to recipe and for creating grocery list based on quanitity
        /// </summary>
        public Recipe Recipe { get; set; }
    }
}