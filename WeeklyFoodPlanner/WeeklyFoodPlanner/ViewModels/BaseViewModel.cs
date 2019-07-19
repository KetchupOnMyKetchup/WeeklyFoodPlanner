using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.Services;

namespace WeeklyFoodPlanner.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<Ingredient> IngredientDataStore => DependencyService.Get<IDataStore<Ingredient>>() ?? App.Database.Ingredient;
        public IDataStore<Recipe> RecipeDataStore => DependencyService.Get<IDataStore<Recipe>>() ?? App.Database.Recipe;
        public IDataStore<Meal> MealDataStore => DependencyService.Get<IDataStore<Meal>>() ?? App.Database.Meals;

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
