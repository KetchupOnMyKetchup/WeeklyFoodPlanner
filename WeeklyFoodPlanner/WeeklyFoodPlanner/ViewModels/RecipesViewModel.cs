using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.Views;

namespace WeeklyFoodPlanner.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public RecipesViewModel()
        {
            Title = "Recipes List";
            Items = new ObservableCollection<Recipe>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewRecipePage, Recipe>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Recipe;
                Items.Add(newItem);
                await DataStore.AddAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}