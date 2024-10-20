using System;
using System.Transactions;

namespace Accounts_Interest_Spreadsheet.Models
{

    // This Model needs to be finished 
	
        public class TransactionData
        {
            public string AccountId { get; set; }
            public List<Transaction> Transactions { get; set; }
        }
    
}

