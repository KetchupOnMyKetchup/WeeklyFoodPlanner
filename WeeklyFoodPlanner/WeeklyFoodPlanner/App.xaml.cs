using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeeklyFoodPlanner.Data;
using WeeklyFoodPlanner.Views;
using System.IO;

namespace WeeklyFoodPlanner
{
    public partial class App : Application
    {
        static FoodDatabase database;

        public static FoodDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FoodDatabase(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FoodSQLite.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
