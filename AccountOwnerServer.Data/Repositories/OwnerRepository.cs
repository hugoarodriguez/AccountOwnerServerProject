using AccountOwnerServer.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private MySQLConfiguration _connectionString;
        public OwnerRepository(MySQLConfiguration conectionString)
        {
            _connectionString = conectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public Task<bool> DeleteOwner()
        {
            var db = dbConnection();
            MySqlCommand cmd = new MySqlCommand();

            throw new NotImplementedException();
        }

        public Task<IEnumerable<Owner>> GetAllOwners()
        {
            throw new NotImplementedException();
        }

        public Task<Owner> GetOwnerDetails()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertOwner()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOwner()
        {
            throw new NotImplementedException();
        }
    }
}
