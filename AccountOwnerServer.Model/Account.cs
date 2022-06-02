using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Model
{
    public class Account
    {
        private string accountId;
        private DateTime date;
        private string accountType;
        private string ownerId;

        public string AccountId { get => accountId; set => accountId = value; }
        public DateTime Date { get => date; set => date = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public string OwnerId { get => ownerId; set => ownerId = value; }
    }
}
