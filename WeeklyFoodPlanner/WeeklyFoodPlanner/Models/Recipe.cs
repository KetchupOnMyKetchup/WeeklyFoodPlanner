using System;
using System.Collections.Generic;
using WeeklyFoodPlanner.Helpers;

namespace WeeklyFoodPlanner.Models
{
    /// <summary>
    /// Recipes that can be filtered by tag for planning. 
    /// Able to be linked to a Meal and provide Instructions and Ingredients.
    /// </summary>
    public class Recipe : BaseEntity
    {
        /// <summary>
        /// Description of the Recipe
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// URL links to photos of the recipe, for example on Instagram posts, Google Photos, or Azure blob storage
        /// </summary>
        public List<string> PhotoLinks { get; set; }

        /// <summary>
        /// Instructions for the Recipe
        /// </summary>
        public string Instructions { get; set; }

        /// <summary>
        /// Used to help filter recipes when searching for a certain type of food or diet plan
        /// </summary>
        public List<HelperEnums.Tags> Tags { get; set; }

        /// <summary>
        /// List of the ingredients and quantities
        /// </summary>
        public List<Ingredient> Ingredients { get; set; }
    }
}