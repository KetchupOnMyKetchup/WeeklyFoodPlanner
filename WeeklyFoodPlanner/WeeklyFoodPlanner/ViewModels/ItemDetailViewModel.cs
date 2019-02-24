using System;

using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Recipe Recipe { get; set; }
        public string Name { get; }
        public ItemDetailViewModel(Recipe recipe = null)
        {
            Title = recipe?.Name;
            Name = recipe.Name;
            Recipe = recipe;
        }
    }
}
