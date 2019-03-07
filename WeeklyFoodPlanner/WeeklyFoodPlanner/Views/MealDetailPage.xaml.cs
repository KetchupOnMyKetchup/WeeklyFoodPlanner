using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.ViewModels;

namespace WeeklyFoodPlanner.Views
{
    public partial class MealDetailPage : ContentPage
    {
        MealDetailViewModel viewModel;

        public MealDetailPage(MealDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public MealDetailPage()
        {
            InitializeComponent();

            var Meal = new Recipe
            {
                Name = "Meal 1",
                Description = "This is an Meal description."
            };

            viewModel = new MealDetailViewModel(Meal);
            BindingContext = viewModel;
        }

        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }
    }
}