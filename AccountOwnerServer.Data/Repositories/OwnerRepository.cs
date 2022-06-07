using AccountOwnerServer.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public async Task<IEnumerable<Owner>> GetAllOwners()
        {
            var db = dbConnection();
            MySqlCommand cmd = new MySqlCommand("SP_SELECT_OWNERS", db);
            cmd.CommandType = CommandType.StoredProcedure;
            db.Open();

            MySqlDataAdapter theDataAdapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            await theDataAdapter.FillAsync(ds);

            DataTable dt = ds.Tables[0];

            var data = dt.AsEnumerable().Select(row =>
            new Owner
            {
                OwnerId = (string)row["OwnerId"],
                Name = (string)row["Name"],
                Date = (DateTime)row["DateOfBirth"],
                Address = (string)row["Address"],

            });

            return data;
        }

        public Task<Owner> GetOwnerDetails(string ownerId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertOwner(Owner owner)
        {
            var db = dbConnection();
            MySqlCommand cmd = new MySqlCommand("SP_INSERT_OWNER", db);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_OWNER", owner.OwnerId);
            cmd.Parameters.AddWithValue("@NAME_OWNER", owner.Name);
            cmd.Parameters.AddWithValue("@DOB_OWNER", owner.Date);
            cmd.Parameters.AddWithValue("@ADDRESS_OWNER", owner.Address);

            var result = await cmd.ExecuteNonQueryAsync();

            return result > 0;
        }

        public async Task<bool> UpdateOwner(Owner owner)
        {
            var db = dbConnection();
            MySqlCommand cmd = new MySqlCommand("SP_UPDATE_OWNER", db);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_OWNER", owner.OwnerId);
            cmd.Parameters.AddWithValue("@NAME_OWNER", owner.Name);
            cmd.Parameters.AddWithValue("@DOB_OWNER", owner.Date);
            cmd.Parameters.AddWithValue("@ADDRESS_OWNER", owner.Address);

            var result = await cmd.ExecuteNonQueryAsync();

            return result > 0;
        }

        public Task<bool> DeleteOwner(string ownerId)
        {
            throw new NotImplementedException();
        }
    }
}
