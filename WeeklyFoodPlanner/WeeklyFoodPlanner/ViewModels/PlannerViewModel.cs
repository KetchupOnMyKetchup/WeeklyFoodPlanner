using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.Services;
using WeeklyFoodPlanner.Views;
using Xamarin.Forms;

namespace WeeklyFoodPlanner.ViewModels
{
    public class PlannerViewModel : BaseViewModel
    {
        public DayOfWeek Today { get => DateTime.Today.DayOfWeek; }

        // use this to keep a full unfiltered list of all meals
        public List<Meal> AllItems { get; set; }

        private IMealsRepository _repo = new MealsRepository();

        // change all items to meal
        // change all recipe level to meal
        private ObservableCollection<Recipe> items;

        public ObservableCollection<Recipe> Items { get => items; set => SetProperty(ref items, value); }
        public Command LoadItemsCommand { get; set; }
        public Command WeekDayCommand { get; set; }

        public PlannerViewModel()
        {
            Title = "Weekly Planner";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

            Items = new ObservableCollection<Recipe>();
            //Items = new ObservableCollection<Recipe>(_repo.GetMealsAsync().Result);


            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            WeekDayCommand = new Command(day => ExecuteWeekDayCommand(day));

            MessagingCenter.Subscribe<NewRecipePage, Recipe>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Recipe;
                Items.Add(newItem);
                await DataStore.AddAsync(newItem);
            });
        }

        private void ExecuteWeekDayCommand(object day)
        {
            // do logic where day of the week is clicked and filter the list of "Items" that is shown

            // to clear out list
            // Items.Clear();
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

        public ICommand OpenWebCommand { get; }
    }
}