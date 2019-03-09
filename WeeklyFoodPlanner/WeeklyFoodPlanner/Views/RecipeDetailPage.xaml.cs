using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.ViewModels;

namespace WeeklyFoodPlanner.Views
{
    public partial class RecipeDetailPage : ContentPage
    {
        RecipeDetailViewModel viewModel;

        public RecipeDetailPage(RecipeDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public RecipeDetailPage()
        {
            InitializeComponent();

            var item = new Recipe
            {
                Name = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new RecipeDetailViewModel(item);
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