using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Common
{
    // Holds a collection of clients
    public class ClientCollection : BindingList<Client>
    {
        // Calculates the total YtdSales
        public decimal TotalYtdSales => this.Sum(client => client.YtdSales);

        // Calculates the count of clients with credit holds
        public int CreditHoldCount => this.Count(client => client.CreditHold);
    }
}
