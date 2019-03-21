using System;
using System.Collections.Generic;
using WeeklyFoodPlanner.Helpers;
using SQLite;

namespace WeeklyFoodPlanner.Models
{
    public class Ingredient : BaseEntity
    {
        public int Quantity { get; set; }
        
        public HelperEnums.QuantityType QuantityType { get; set; }
    }
}