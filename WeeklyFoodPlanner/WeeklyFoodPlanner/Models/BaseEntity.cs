using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WeeklyFoodPlanner.Models
{
    /// <summary>
    /// Base entity for the models with Id and Name
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Id of the model item
        /// This should be the primary key and auto-increment in SQLite
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Name of the model item
        /// </summary>
        public string Name { get; set; }
    }
}
