using System;
using System.Collections.Generic; 

namespace Accounts_Interest_Spreadsheet.Models
{
    public class AccountData

        // Keep this Model CLEAN for the Data structure 

    {
        public AccountData() { }

        public BankDetails BankDetails { get; set; }
        public string AccountId { get; set; }
        public string AccountType { get; set; }
        public string Currency { get; set; }
        public AccountHolder AccountHolder { get; set; }
        public Balance Balance { get; set; }
        public bool Ceditable { get; set; }
        public bool Debitable { get; set; }
        public int Version { get; set; }
        public double InterestRate { get; set; }
        public DateTime NextInterestPaymentDate { get; set; }
        public string NextInterestPaymentTime { get; set; }
        public Metadata Metadata { get; set; }

        
        public static List<AccountData> GenerateDummyData()
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
                }
                // Add more stuff here for the othre accounts **
            };
        }
    }

    public class BankDetails
    {
        public string PrimaryBankIdentificationNumber { get; set; }
        public string BankName { get; set; }
        public string Country { get; set; }
    }

    public class AccountHolder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }

    public class Balance
    {
        public double Available { get; set; }
        public double Current { get; set; }
        public string Currency { get; set; }
    }

    public class Metadata
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdated { get; set; } 
        public string Status { get; set; } // What the hell does this mean? Not neccessary for this project 
        public bool IsVerified { get; set; }
    }
}
