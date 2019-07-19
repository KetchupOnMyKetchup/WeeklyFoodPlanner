using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace WeeklyFoodPlanner.ViewModels
{
    public class NewMealViewModel : BaseViewModel
    {
        public NewMealViewModel()
        {
            Title = "Grocery List";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}