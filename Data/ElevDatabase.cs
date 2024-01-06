using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Aplicatie.Models;

namespace Aplicatie.Data
{
   public class ElevDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ElevDatabase(string databasePath)
        {
            _database = new SQLiteAsyncConnection(databasePath);
            _database.CreateTableAsync<Elev>().Wait();
        }

        public Task<List<Elev>> ObtinereEleviAsync()
        {
            return _database.Table<Elev>().ToListAsync();
        }

        public Task<Elev> ObtinereElevAsync(int id)
        {
            return _database.Table<Elev>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SalvareElevAsync(Elev elev)
        {
            if (elev.Id != 0)
            {
                return _database.UpdateAsync(elev);
            }
            else
            {
                return _database.InsertAsync(elev);
            }
        }

        public Task<int> StergereElevAsync(Elev elev)
        {
            return _database.DeleteAsync(elev);
        }
    }
}
