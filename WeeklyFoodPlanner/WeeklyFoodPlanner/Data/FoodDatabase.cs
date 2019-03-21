using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.Data
{
    public class FoodDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public FoodDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Meal>().Wait();
            _database.CreateTableAsync<Recipe>().Wait();
            _database.CreateTableAsync<Ingredient>().Wait();
        }
    }
}
