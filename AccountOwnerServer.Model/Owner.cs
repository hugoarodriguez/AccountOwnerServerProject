using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Model
{
    public class Owner
    {
        private string ownerId;
        private string name;
        private DateTime date;
        private string address;

        public string OwnerId { get => ownerId; set => ownerId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Address { get => address; set => address = value; }
    }
}
