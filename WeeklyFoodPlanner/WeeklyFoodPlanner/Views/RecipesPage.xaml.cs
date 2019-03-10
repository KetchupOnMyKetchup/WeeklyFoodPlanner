using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.Views;
using WeeklyFoodPlanner.ViewModels;

namespace WeeklyFoodPlanner.Views
{
    public partial class RecipesPage : ContentPage
    {
        RecipesViewModel viewModel;

        public RecipesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new RecipesViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Recipe;
            if (item == null)
                return;

            await Navigation.PushAsync(new RecipeDetailPage(new RecipeDetailViewModel(item)));

            // Manually deselect item.
            RecipeListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewRecipePage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}