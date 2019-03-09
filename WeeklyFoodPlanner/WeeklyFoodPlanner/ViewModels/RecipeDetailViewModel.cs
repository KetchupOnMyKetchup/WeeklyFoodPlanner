using System;

using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.ViewModels
{
    public class RecipeDetailViewModel : BaseViewModel
    {
        public Recipe Recipe { get; set; }
        public string Name { get; }
        public RecipeDetailViewModel(Recipe recipe = null)
        {
            Title = recipe?.Name;
            Name = recipe.Name;
            Recipe = recipe;
        }
    }
}
