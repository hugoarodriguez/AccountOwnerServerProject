using AccountOwnerServer.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private MySQLConfiguration _connectionString;
        public AccountRepository(MySQLConfiguration conectionString)
        {
            _connectionString = conectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        
        public Task<bool> DeleteAccount()
        {
            var db = dbConnection();
            MySqlCommand cmd = new MySqlCommand();

            throw new NotImplementedException();
        }

        public Task<Account> GetAccountDetails()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetAllAcounts()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAccount()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAccount()
        {
            throw new NotImplementedException();
        }
    }
}
