using System;
using System.Collections.Generic;

namespace MoneyView.Models.Money
{
    public class Currency
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}
