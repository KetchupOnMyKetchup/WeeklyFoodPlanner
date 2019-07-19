using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using WeeklyFoodPlanner.Models;
using WeeklyFoodPlanner.Services;

namespace WeeklyFoodPlanner.Data
{
    public class FoodDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public FoodDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            //Meals = new DataStore<Meal>(_database);
            //Recipe = new DataStore<Recipe>(_database);
            Ingredient = new DataStore<Ingredient>(_database);
        }

        internal IDataStore<Meal> Meals { get; }

        internal IDataStore<Recipe> Recipe { get; }

        internal IDataStore<Ingredient> Ingredient { get; }
    }
}
