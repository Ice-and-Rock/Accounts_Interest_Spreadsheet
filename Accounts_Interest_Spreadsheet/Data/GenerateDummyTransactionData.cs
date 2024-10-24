using System;
using Accounts_Interest_Spreadsheet.Models;

namespace Accounts_Interest_Spreadsheet.Data
{
	public static class GenerateDummyTransactionData
	{
		
			public static List<TransactionData> GetDummyTransactions(string accountId) 
			{
                return new List<TransactionData>
                {
                    new TransactionData
                    {
                        AccountId = accountId,
                        Transaction = new Transaction
                        {
                            TransactionId = "tx1",
                            Date = new DateTime(2024, 10, 10),
                            Amount = 100.00m,
                            Details = new Details
                            {
                                Description = "Deposit",
                                OriginId = "Branch-123",
                                OriginAccountHolder = "Mr. Sample Cheif",
                                Interest = false
                            },
                            Direction = "credit"
                        }
                    },
                    new TransactionData
                    {
                        AccountId = accountId,
                        Transaction = new Transaction
                        {
                            TransactionId = "tx2",
                            Date = new DateTime(2024, 10, 12),
                            Amount = 50.00m,
                            Details = new Details
                            {
                                Description = "Withdrawal",
                                OriginId = "ATM-456",
                                OriginAccountHolder = "Mr. Sample Cheif",
                                Interest = false
                            },
                            Direction = "debit"
                        }
                    },
                    new TransactionData
                    {
                        AccountId = accountId,
                        Transaction = new Transaction
                        {
                            TransactionId = "tx3",
                            Date = new DateTime(2024, 10, 15),
                            Amount = 200.00m,
                            Details = new Details
                            {
                                Description = "Interest Payment",
                                OriginId = "Bank-123",
                                OriginAccountHolder = "SampleCompany",
                                Interest = true
                            },
                            Direction = "credit"
                        }
                    },
                    new TransactionData
                    {
                        AccountId = accountId,
                        Transaction = new Transaction
                        {
                            TransactionId = "tx4",
                            Date = new DateTime(2024, 10, 20),
                            Amount = 75.00m,
                            Details = new Details
                            {
                                Description = "Online Purchase",
                                OriginId = "Merchant-789",
                                OriginAccountHolder = "Mr. Sample Cheif",
                                Interest = false
                            },
                            Direction = "debit"
                        }
                    }
                };
		}

	}
};

