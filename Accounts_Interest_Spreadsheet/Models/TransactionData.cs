using System;
using System.Transactions;

namespace Accounts_Interest_Spreadsheet.Models
{

    // This Model needs to be finished 
	
        public class TransactionData
        {
            public string AccountId { get; set; }
            public Transaction Transaction { get; set; }
        };
    
}

public class Transaction
{
    public string TransactionId { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public Details Details   { get; set; }
    public string Direction { get; set; }
}

public class Details
{
    public string Description { get; set; }
    public string OriginId { get; set; }
    public string OriginAccountHolder { get; set; }
    public string RecipientId { get; set; }
    public string RecipientAccountHolder { get; set; }
    public bool Interest { get; set; }
}