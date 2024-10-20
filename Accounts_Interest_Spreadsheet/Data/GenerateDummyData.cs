using System;
using System.Collections.Generic; 
using Accounts_Interest_Spreadsheet.Models;


namespace Accounts_Interest_Spreadsheet.Data
{
	public static class GenerateDummyData
	{
		public static List<AccountData> CreateDummyAccounts()
		{
            return new List<AccountData> 
            {
                new AccountData
                {
                    AccountId = "12345",
                    AccountType = "Savings",
                    Currency = "USD",
                    InterestRate = 1.5,
                    BankDetails = new BankDetails
                    {
                        BankName = "Bank A",
                        Country = "United Kingdom",
                        PrimaryBankIdentificationNumber = "123456789"
                    },
                    Balance = new Balance
                    {
                        Current = 1500.00,
                        Available = 1500.00,
                        Currency = "USD"
                    },
                    AccountHolder = new AccountHolder
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "john.doe@example.com",
                        Phone = "+1-555-123-4567",
                        Address = new Address
                        {
                            Street = "123 Elm St",
                            City = "Somewhere",
                            State = "CA",
                            ZipCode = "90210",
                            Country = "USA"
                        }
                    },
                    Metadata = new Metadata
                    {
                        CreationDate = DateTime.Parse("2020-01-15T08:00:00Z"),
                        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
                        Status = "Active",
                        IsVerified = true
                    }
                },
                // Add more stuff here for the othre accounts **
                new AccountData
{
    AccountId = "23456",
    AccountType = "Savings",
    Currency = "USD",
    InterestRate = 1.2,
    BankDetails = new BankDetails
    {
        BankName = "Bank C",
        Country = "Canada",
        PrimaryBankIdentificationNumber = "135792468"
    },
    Balance = new Balance
    {
        Current = 3000.00,
        Available = 3000.00,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Alice",
        LastName = "Johnson",
        Email = "alice.johnson@example.com",
        Phone = "+1-555-234-5678",
        Address = new Address
        {
            Street = "789 Pine St",
            City = "Toronto",
            State = "ON",
            ZipCode = "M5H 2N2",
            Country = "Canada"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2019-03-10T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "34567",
    AccountType = "Checking",
    Currency = "USD",
    InterestRate = 0.3,
    BankDetails = new BankDetails
    {
        BankName = "Bank D",
        Country = "Australia",
        PrimaryBankIdentificationNumber = "246813579"
    },
    Balance = new Balance
    {
        Current = 750.50,
        Available = 750.50,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Bob",
        LastName = "Williams",
        Email = "bob.williams@example.com",
        Phone = "+1-555-345-6789",
        Address = new Address
        {
            Street = "321 Cedar St",
            City = "Sydney",
            State = "NSW",
            ZipCode = "2000",
            Country = "Australia"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2021-05-20T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "45678",
    AccountType = "Business",
    Currency = "USD",
    InterestRate = 2.0,
    BankDetails = new BankDetails
    {
        BankName = "Bank E",
        Country = "United Kingdom",
        PrimaryBankIdentificationNumber = "987123456"
    },
    Balance = new Balance
    {
        Current = 15000.00,
        Available = 15000.00,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Charlie",
        LastName = "Brown",
        Email = "charlie.brown@example.com",
        Phone = "+1-555-456-7890",
        Address = new Address
        {
            Street = "654 Birch St",
            City = "London",
            State = "England",
            ZipCode = "EC1A 1BB",
            Country = "UK"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2018-07-15T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "56789",
    AccountType = "Checking",
    Currency = "USD",
    InterestRate = 0.1,
    BankDetails = new BankDetails
    {
        BankName = "Bank F",
        Country = "New Zealand",
        PrimaryBankIdentificationNumber = "321654987"
    },
    Balance = new Balance
    {
        Current = 500.00,
        Available = 500.00,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Diana",
        LastName = "Prince",
        Email = "diana.prince@example.com",
        Phone = "+1-555-567-8901",
        Address = new Address
        {
            Street = "456 Oak St",
            City = "Wellington",
            State = "WGN",
            ZipCode = "6011",
            Country = "New Zealand"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2022-11-25T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "67890",
    AccountType = "Savings",
    Currency = "USD",
    InterestRate = 1.8,
    BankDetails = new BankDetails
    {
        BankName = "Bank G",
        Country = "Ireland",
        PrimaryBankIdentificationNumber = "159753468"
    },
    Balance = new Balance
    {
        Current = 4000.00,
        Available = 4000.00,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Edward",
        LastName = "Norton",
        Email = "edward.norton@example.com",
        Phone = "+1-555-678-9012",
        Address = new Address
        {
            Street = "852 Maple St",
            City = "Dublin",
            State = "Leinster",
            ZipCode = "D02 1A5",
            Country = "Ireland"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2020-09-05T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "78901",
    AccountType = "Business",
    Currency = "USD",
    InterestRate = 2.5,
    BankDetails = new BankDetails
    {
        BankName = "Bank H",
        Country = "USA",
        PrimaryBankIdentificationNumber = "258369147"
    },
    Balance = new Balance
    {
        Current = 30000.00,
        Available = 29000.00,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Felicity",
        LastName = "Jones",
        Email = "felicity.jones@example.com",
        Phone = "+1-555-789-0123",
        Address = new Address
        {
            Street = "789 Birch St",
            City = "Los Angeles",
            State = "CA",
            ZipCode = "90001",
            Country = "USA"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2017-12-20T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "89012",
    AccountType = "Savings",
    Currency = "USD",
    InterestRate = 1.0,
    BankDetails = new BankDetails
    {
        BankName = "Bank I",
        Country = "USA",
        PrimaryBankIdentificationNumber = "789456123"
    },
    Balance = new Balance
    {
        Current = 2200.50,
        Available = 2200.50,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "George",
        LastName = "Clark",
        Email = "george.clark@example.com",
        Phone = "+1-555-890-1234",
        Address = new Address
        {
            Street = "456 Elm St",
            City = "Miami",
            State = "FL",
            ZipCode = "33101",
            Country = "USA"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2023-03-15T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "90123",
    AccountType = "Checking",
    Currency = "USD",
    InterestRate = 0.4,
    BankDetails = new BankDetails
    {
        BankName = "Bank J",
        Country = "USA",
        PrimaryBankIdentificationNumber = "321987654"
    },
    Balance = new Balance
    {
        Current = 950.75,
        Available = 950.75,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Helen",
        LastName = "Keller",
        Email = "helen.keller@example.com",
        Phone = "+1-555-321-0987",
        Address = new Address
        {
            Street = "987 Oak St",
            City = "Seattle",
            State = "WA",
            ZipCode = "98101",
            Country = "USA"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2022-01-05T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
},

new AccountData
{
    AccountId = "01234",
    AccountType = "Business",
    Currency = "USD",
    InterestRate = 3.0,
    BankDetails = new BankDetails
    {
        BankName = "Bank K",
        Country = "USA",
        PrimaryBankIdentificationNumber = "654321987"
    },
    Balance = new Balance
    {
        Current = 40000.00,
        Available = 39000.00,
        Currency = "USD"
    },
    AccountHolder = new AccountHolder
    {
        FirstName = "Irene",
        LastName = "Adler",
        Email = "irene.adler@example.com",
        Phone = "+1-555-654-3210",
        Address = new Address
        {
            Street = "123 Pine St",
            City = "Boston",
            State = "MA",
            ZipCode = "02108",
            Country = "USA"
        }
    },
    Metadata = new Metadata
    {
        CreationDate = DateTime.Parse("2016-08-12T08:00:00Z"),
        LastUpdated = DateTime.Parse("2024-10-20T10:30:00Z"),
        Status = "Active",
        IsVerified = true
    }
}

            };
        }
	}
}

