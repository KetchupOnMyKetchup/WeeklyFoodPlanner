using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.Views
{
    public partial class NewRecipePage : ContentPage
    {
        public Recipe Item { get; set; }

        public NewRecipePage()
        {
            InitializeComponent();

            Item = new Recipe
            {
                Name = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}