using AccountOwnerServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data.Repositories
{
    public interface IOwnerRepository
    {
        Task<IEnumerable<Owner>> GetAllOwners();
        Task<Owner> GetOwnerDetails();
        Task<bool> InsertOwner();
        Task<bool> UpdateOwner();
        Task<bool> DeleteOwner();
    }
}
