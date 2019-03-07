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

            HighlightDayOfTheWeek();

            BindingContext = viewModel = new PlannerViewModel();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        private void HighlightDayOfTheWeek()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            
            Resources["sunBtn"] = Resources["darkerButton"];
            Resources["monBtn"] = Resources["darkerButton"];
            Resources["tuesBtn"] = Resources["darkerButton"];
            Resources["wedBtn"] = Resources["darkerButton"];
            Resources["thursBtn"] = Resources["darkerButton"];
            Resources["friBtn"] = Resources["darkerButton"];
            Resources["satBtn"] = Resources["darkerButton"];

            switch (today)
            {
                case DayOfWeek.Sunday:
                    Resources["sunBtn"] = Resources["orangeButton"];
                    break;
                case DayOfWeek.Monday:
                    Resources["monBtn"] = Resources["orangeButton"];
                    break;
                case DayOfWeek.Tuesday:
                    Resources["tuesBtn"] = Resources["orangeButton"];
                    break;
                case DayOfWeek.Wednesday:
                    Resources["wedBtn"] = Resources["orangeButton"];
                    break;
                case DayOfWeek.Thursday:
                    Resources["thursBtn"] = Resources["orangeButton"];
                    break;
                case DayOfWeek.Friday:
                    Resources["friBtn"] = Resources["orangeButton"];
                    break;
                case DayOfWeek.Saturday:
                    Resources["satBtn"] = Resources["orangeButton"];
                    break;
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Recipe;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }

        async void AddMeal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}