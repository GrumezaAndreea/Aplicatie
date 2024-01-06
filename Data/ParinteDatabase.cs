using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Aplicatie.Models;

namespace Aplicatie.Data
{
    public class ParinteDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ParinteDatabase(string caleBazaDate)
        {
            _database = new SQLiteAsyncConnection(caleBazaDate);
            _database.CreateTableAsync<Parinte>().Wait();
        }

        public Task<List<Parinte>> ObtinereParintiAsync()
        {
            return _database.Table<Parinte>().ToListAsync();
        }

        public Task<Parinte> ObtinereParinteAsync(int id)
        {
            return _database.Table<Parinte>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SalvareParinteAsync(Parinte parinte)
        {
            if (parinte.Id != 0)
            {
                return _database.UpdateAsync(parinte);
            }
            else
            {
                return _database.InsertAsync(parinte);
            }
        }

        public Task<int> StergereParinteAsync(Parinte parinte)
        {
            return _database.DeleteAsync(parinte);
        }
    }
}
