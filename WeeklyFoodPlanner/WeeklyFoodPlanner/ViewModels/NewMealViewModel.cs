using System;
using WeeklyFoodPlanner.Helpers;
using WeeklyFoodPlanner.Models;
using Xamarin.Forms;

namespace WeeklyFoodPlanner.ViewModels
{
    public class GroceryViewModel : BaseViewModel
    {
        public Meal Meal { get; set; }

        public GroceryViewModel()
        {
            Title = "Grocery List";

            Meal = new Meal
            {
                Name = "Meal name",
                Recipe = new Recipe
                {
                    Name = "Salmon Sashimi",
                    Description = "Delish"
                },
                MealType = HelperEnums.MealType.Breakfast
            };
        }

        public void SaveMeal()
        {
            MessagingCenter.Send(this, "AddMeal", Meal);
        }
    }
}