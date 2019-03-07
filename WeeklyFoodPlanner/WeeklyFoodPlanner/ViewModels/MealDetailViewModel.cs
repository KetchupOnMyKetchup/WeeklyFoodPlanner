using System;

using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.ViewModels
{
    public class MealDetailViewModel : BaseViewModel
    {
        public Recipe Recipe { get; set; }
        public string Name { get; }
        public MealDetailViewModel(Recipe recipe = null)
        {
            Title = recipe?.Name;
            Name = recipe.Name;
            Recipe = recipe;
        }
    }
}
