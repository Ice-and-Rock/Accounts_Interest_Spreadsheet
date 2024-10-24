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

    }; }

        
    

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


