using System;
using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeeklyFoodPlanner.Views
{
    public partial class PlannerPage : ContentPage
    {
        PlannerViewModel viewModel;

        public PlannerPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PlannerViewModel();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewMealPage()));
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Recipe;
            if (item == null)
                return;

            await Navigation.PushAsync(new RecipeDetailPage(new RecipeDetailViewModel(item)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }

        async void AddMeal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewMealPage()));
        }

        async void ShowMealsForDate_Clicked(object sender, EventArgs e)
        {
            // load a subset of the items list

            await Navigation.PushModalAsync(new NavigationPage(new NewMealPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}