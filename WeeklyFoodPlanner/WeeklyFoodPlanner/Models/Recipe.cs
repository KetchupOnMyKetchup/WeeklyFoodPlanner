using System;
using System.Collections.Generic;

namespace WeeklyFoodPlanner.Models
{
    public class Recipe : BaseEntity
    {
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}