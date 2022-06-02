using AccountOwnerServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data.Repositories
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAllAcounts();
        Task<Account> GetAccountDetails();
        Task<bool> InsertAccount();
        Task<bool> UpdateAccount();
        Task<bool> DeleteAccount();
    }
}
