using System;

namespace Accounts_Interest_Spreadsheet.Models
{
    public class BankAccountData
    {
        public int Id { get; set; } // Unique identifier for the account!!
        public DateTime Date { get; set; }
        public string BankName { get; set; } = string.Empty; // initialises so it's not null
        public string BankLocation { get; set; } = string.Empty;
        public decimal CurrentAmount { get; set; }
        public decimal InterestRate { get; set;}
        public decimal TransactionsIn { get; set;}
        public decimal TransactionsOut {get; set; }

        // timeZoneInfo below finds the information! amazing.
        public TimeZoneInfo BankTimeZone { get; set; }

        //fields for interst payment schedule
        public DateTime NextInterestPaymentDate { get; set;}
        public TimeSpan NextInterestPaymentTime { get; set; } = TimeSpan.FromHours(24);


        // Calculated properties **CHECK
        public decimal DailyInterest => CalculateDailyInterest();
        public decimal TomorrowAmount => CalculateTomorrowAmount();
        public decimal EndOfMonthAmount => CalculateEndOfMonthAmount();  // CHECK, need a method?**

        private decimal CalculateDailyInterest()
        {
            // Daily interest calculation to two decimalls
            return Math.Round(CurrentAmount * (InterestRate / 100) / 365, 2); 
        }

        private decimal CalculateTomorrowAmount()
        {
            // returns the calculation rounding to two decimals for tomorrow's amount
                // This function must eventually:
                    // chasnge colour depending on Account.InterestPaymentSchedule (to show projected/actual amount)
                    // open a "Tooltip" box to show which days interest is paid (switch case) 
            return Math.Round(CurrentAmount + TransactionsIn - TransactionsOut + DailyInterest, 2);
        }

        public decimal CalculateEndOfMonthAmount()
        {
            // returns the projected end of month amount, based on current amount/interest/number of days in month
            return Math.Round(CurrentAmount + DailyInterest * 30); 
        }

        // Method to calculate the next interest payment date based on a given time/day set
        // CHECK these calculations are correct ⚠️
        private DateTime CalculateNextInterestPaymentDate(string paymentFrequency)
        {
            DateTime today = DateTime.Today;

            return paymentFrequency.ToLower() switch
            {
                "daily" => today.AddDays(1), 
                "threetimesaweek" => CalculateThreeTimesAWeek(today),
                "weekly" => today.AddDays(7), 
                _ => today.AddDays(1), // Default to daily if no valid option. Change colour of this in futuer?**
            };
        }

        // Function to calculate "three times a week" payment dat. 
        private DateTime CalculateThreeTimesAWeek(DateTime today)
        {
            // Assuming interest payments are on Monday, Wednesday, and Friday
            var dayOfWeek = today.DayOfWeek;

            return dayOfWeek switch
            {
                DayOfWeek.Monday => today.AddDays(2),   // Wednesday
                DayOfWeek.Wednesday => today.AddDays(2), // Friday
                DayOfWeek.Friday => today.AddDays(3),   // Next Monday
                _ => today.AddDays(1) // If the day is not Mon/Wed/Fri, default to next day
            };
        }






        // DUMMY DATA... basic version*
        // To be ammended to use variable integers from API fetch requests
        public static List<BankAccountData> GenerateDummyData()
        {
            return new List<BankAccountData>
{
new BankAccountData
        {
            Id = 1,
            BankName = "Bank A",
            BankLocation = "New York, USA",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 10000m,
            InterestRate = 2.5m,
            TransactionsIn = 0m,
            TransactionsOut = 1000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 2),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 2,
            BankName = "Bank B",
            BankLocation = "London, UK",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 20000m,
            InterestRate = 2.5m,
            TransactionsIn = 0m,
            TransactionsOut = 1000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 4),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 3,
            BankName = "Bank C",
            BankLocation = "Sydney, Australia",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 15000m,
            InterestRate = 1.8m,
            TransactionsIn = 200m,
            TransactionsOut = 500m,
            NextInterestPaymentDate = new DateTime(2024, 10, 8),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 4,
            BankName = "Bank D",
            BankLocation = "Tokyo, Japan",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 52000m,
            InterestRate = 3.0m,
            TransactionsIn = 0m,
            TransactionsOut = 2000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 2),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 5,
            BankName = "Bank E",
            BankLocation = "Berlin, Germany",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 4600m,
            InterestRate = 1.2m,
            TransactionsIn = 300m,
            TransactionsOut = 100m,
            NextInterestPaymentDate = new DateTime(2024, 10, 4),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 6,
            BankName = "Bank F",
            BankLocation = "Paris, France",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 19800m,
            InterestRate = 2.2m,
            TransactionsIn = 500m,
            TransactionsOut = 600m,
            NextInterestPaymentDate = new DateTime(2024, 10, 8),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 7,
            BankName = "Bank G",
            BankLocation = "Toronto, Canada",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 76000m,
            InterestRate = 3.3m,
            TransactionsIn = 1000m,
            TransactionsOut = 1500m,
            NextInterestPaymentDate = new DateTime(2024, 10, 2),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 8,
            BankName = "Bank H",
            BankLocation = "Singapore",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 31000m,
            InterestRate = 2.7m,
            TransactionsIn = 700m,
            TransactionsOut = 400m,
            NextInterestPaymentDate = new DateTime(2024, 10, 4),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 9,
            BankName = "Bank I",
            BankLocation = "Mumbai, India",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 25000m,
            InterestRate = 1.9m,
            TransactionsIn = 500m,
            TransactionsOut = 300m,
            NextInterestPaymentDate = new DateTime(2024, 10, 8),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 10,
            BankName = "Bank J",
            BankLocation = "Los Angeles, USA",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 89000m,
            InterestRate = 3.5m,
            TransactionsIn = 1200m,
            TransactionsOut = 2000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 2),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 11,
            BankName = "Bank K",
            BankLocation = "Cairo, Egypt",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Egypt Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 10450m,
            InterestRate = 1.5m,
            TransactionsIn = 100m,
            TransactionsOut = 50m,
            NextInterestPaymentDate = new DateTime(2024, 10, 4),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 12,
            BankName = "Bank L",
            BankLocation = "Seoul, South Korea",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 64000m,
            InterestRate = 2.9m,
            TransactionsIn = 500m,
            TransactionsOut = 800m,
            NextInterestPaymentDate = new DateTime(2024, 10, 8),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 13,
            BankName = "Bank M",
            BankLocation = "Moscow, Russia",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 87000m,
            InterestRate = 3.6m,
            TransactionsIn = 0m,
            TransactionsOut = 3000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 2),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 14,
            BankName = "Bank N",
            BankLocation = "Rome, Italy",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 54000m,
            InterestRate = 2.4m,
            TransactionsIn = 800m,
            TransactionsOut = 1000m,
            NextInterestPaymentDate = new DateTime(2024, 10, 4),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        },
        new BankAccountData
        {
            Id = 15,
            BankName = "Bank O",
            BankLocation = "Helsinki, Finland",
            BankTimeZone = TimeZoneInfo.FindSystemTimeZoneById("FLE Standard Time"),
            Date = new DateTime(2024, 10, 1),
            CurrentAmount = 23000m,
            InterestRate = 1.7m,
            TransactionsIn = 400m,
            TransactionsOut = 200m,
            NextInterestPaymentDate = new DateTime(2024, 10, 8),
            NextInterestPaymentTime = TimeSpan.FromHours(24)
        }
};

        }
        }
    }
