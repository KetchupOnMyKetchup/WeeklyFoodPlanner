using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace WeeklyFoodPlanner.ViewModels
{
    public class GroceryViewModel : BaseViewModel
    {
        public GroceryViewModel()
        {
            Title = "Grocery List";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}