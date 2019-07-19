using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.Services
{
    public class DataStore<T> : IDataStore<T> where T : BaseEntity, new()
    {
        readonly SQLiteAsyncConnection _database;

        public DataStore(SQLiteAsyncConnection connection)
        {
            _database = connection;
            _database.CreateTableAsync<T>().Wait();
        }
        //public BaseDataStore(string dbPath)
        //{
        //    _database = new SQLiteAsyncConnection(dbPath);
        //    _database.CreateTableAsync<T>().Wait();
        //}

        public async Task<bool> AddAsync(T item)
        {
            var result = await _database.InsertAsync(item);
            if (result > 0) return true;
            else return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await GetAsync(id);
            var result = await _database.DeleteAsync(item);

            if (result > 0) return true;
            else return false;
        }

        public Task<T> GetAsync(int id)
        {
            return _database.Table<T>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool forceRefresh = false)
        {
            return await _database.Table<T>().ToListAsync();
        }

        public async Task<bool> UpdateAsync(T item)
        {
            var result = await _database.UpdateAsync(item);
            if (result > 0) return true;
            else return false;
        }
    }
}
