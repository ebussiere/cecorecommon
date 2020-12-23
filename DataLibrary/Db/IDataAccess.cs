using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Db
{
    public interface IDataAccess
    {
        public Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
        public Task<int> SaveData<T>(string storedProcedure, T parameters, string connectionStringName);
    }
}