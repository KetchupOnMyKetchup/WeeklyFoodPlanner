using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace WeeklyFoodPlanner.ViewModels
{
    public class PlannerViewModel : BaseViewModel
    {
        public PlannerViewModel()
        {
            Title = "Planner";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}