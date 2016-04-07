using System;
using System.Collections.Generic;

namespace MoneyView.Models.Money
{
    /// <summary>
    /// Account
    /// </summary>
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Currency Currency { get; set; }
        public virtual List<Record> Records { get; set; }
    }
}
