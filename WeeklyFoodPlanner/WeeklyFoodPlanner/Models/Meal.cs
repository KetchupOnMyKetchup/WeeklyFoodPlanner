using System;
using System.Collections.Generic;

namespace WeeklyFoodPlanner.Models
{
    public class Meal : BaseEntity
    {
        public List<HelperEnums.MealType> MealTypes { get; set; }
        public int NumberDaysToRepeat { get; set; }
        public Recipe Recipe { get; set; }
    }
}