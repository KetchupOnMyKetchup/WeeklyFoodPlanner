using System;
using System.Collections.Generic;

namespace WeeklyFoodPlanner.Models
{
    public class Ingredient : BaseEntity
    {
        public int Quantity { get; set; }
        public HelperEnums.QuantityType QuantityType { get; set; }
    }
}