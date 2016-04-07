using System;
using System.Collections.Generic;

namespace MoneyView.Models.Money
{
    /// <summary>
    /// Record for operation
    /// each record has double record, with Second points to it, quantity negative,
    /// and reverse source and destination account.
    /// Exchange currency may be alternative to source and destination currency
    /// </summary>
    public class Record
    {
        /// <summary>
        /// Id of record
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Timestamp of operation
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// Source account for record
        /// </summary>
        public virtual Account FromAccount { get; set; }
        /// <summary>
        /// Quantity for source account(in the account currency)
        /// </summary>
        public Decimal Quantity { get; set; }
        /// <summary>
        /// Destination account
        /// </summary>
        public virtual Account ToAccount { get; set; }
        /// <summary>
        /// Second record Id for destination account
        /// </summary>
        public virtual Record Second { get; set; }
        /// <summary>
        /// Currency for operation
        /// </summary>
        public Currency Exchange { get; set; }
        /// <summary>
        /// Quantity for exchange currency
        /// </summary>
        public decimal ExchangeQuantity { get; set; }
        /// <summary>
        /// Description of operation
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Is deleted flag
        /// </summary>
        public bool Deleted { get; set; }
        /// <summary>
        /// First version id for operation
        /// </summary>
        public Guid FirstVersion { get; set; }
        /// <summary>
        /// Creation time for record
        /// </summary>
        public DateTime Create { get; set; }
        /// <summary>
        /// Last update time for record
        /// </summary>
        public DateTime LastUpdate { get; set; }
    }
}

