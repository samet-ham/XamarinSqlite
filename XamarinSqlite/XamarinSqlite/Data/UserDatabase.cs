using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinSqlite.Models;

namespace XamarinSqlite.Data
{
    public class UserDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public UserDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetAllAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<User> GetAsync(int id)
        {
            return _database.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveAsync(User user)
        {
            if (user.ID != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

        public Task<int> DeleteAsync(User user)
        {
            return _database.DeleteAsync(user);
        }
    }
}
