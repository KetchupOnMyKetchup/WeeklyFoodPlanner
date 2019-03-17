﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.Services
{
    public class MockMealDataStore : IDataStore<Meal>
    {
        List<Meal> meals;

        public MockMealDataStore()
        {
            meals = new List<Meal>();
            var mockRecipes = new List<Recipe>
            {
                new Recipe { Id = 1, Name = "Breakfast Quiche", Description="Sausage, egg, and spinach.", Ingredients = new List<Ingredient>
                    {
                        new Ingredient {  }
                    }
                },
                new Recipe { Id = 2, Name = "White Bean Soup", Description="White beans in soup." },
                new Recipe { Id = 3, Name = "Garlic Honey Salmon", Description="Pan seared salmon." }
            };

            var mockMeals = new List<Meal>
            {
                new Meal
                {
                     Id = 1,
                     Name = mockRecipes[0].Name,
                     MealType = HelperEnums.MealType.Breakfast,
                     NumberDaysToRepeat = 1,
                     StartDay = 0,
                     Recipe = mockRecipes[0]
                },
                new Meal
                {
                     Id = 2,
                     Name = mockRecipes[1].Name,
                     MealType = HelperEnums.MealType.Snack1,
                     NumberDaysToRepeat = 1,
                     StartDay = 0,
                     Recipe = mockRecipes[1]
                },
                new Meal
                {
                     Id = 3,
                     Name = mockRecipes[2].Name,
                     MealType = HelperEnums.MealType.Lunch,
                     NumberDaysToRepeat = 1,
                     StartDay = 0,
                     Recipe = mockRecipes[2]
                }
            };

            foreach (var meal in mockMeals) meals.Add(meal);
        }

        public async Task<bool> AddAsync(Meal meal)
        {
            meals.Add(meal);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Meal meal)
        {
            var oldItem = meals.Where((Meal arg) => arg.Id == meal.Id).FirstOrDefault();
            meals.Remove(oldItem);
            meals.Add(meal);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var oldMeal = meals.Where((Meal arg) => arg.Id == id).FirstOrDefault();
            meals.Remove(oldMeal);

            return await Task.FromResult(true);
        }

        public async Task<Meal> GetAsync(int id)
        {
            return await Task.FromResult(meals.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Meal>> GetAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(meals);
        }
    }
}