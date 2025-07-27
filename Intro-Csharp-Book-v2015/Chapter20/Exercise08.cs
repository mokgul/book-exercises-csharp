namespace Chapter20;

public static class Exercise08
{
    public static void BankExample()
    {
        var client1 = new Individual("John Smith");
        var deposit = new DepositAccount(client1, 900, 0.05m);
        Console.WriteLine("Deposit Interest (12 months): " + deposit.CalculateInterest(12));

        var client2 = new Company("TechCorp");
        var mortgage = new MortgageAccount(client2, 10000, 0.03m);
        Console.WriteLine("Mortgage Interest (18 months): " + mortgage.CalculateInterest(18));
    }
    
    // Interface for interest calculation
    public interface IInterestAccount
    {
        decimal CalculateInterest(int months);
    }

    // Abstract base class for all customers
    public abstract class Customer
    {
        public string Name { get; set; }

        protected Customer(string name)
        {
            Name = name;
        }
    }

    public class Individual : Customer
    {
        public Individual(string name) : base(name) { }
    }

    public class Company : Customer
    {
        public Company(string name) : base(name) { }
    }

    // Abstract base class for all accounts
    public abstract class Account : IInterestAccount
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal MonthlyInterestRate { get; set; } // As decimal (e.g., 0.05 for 5%)

        protected Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            Customer = customer;
            Balance = balance;
            MonthlyInterestRate = monthlyInterestRate;
        }

        public abstract decimal CalculateInterest(int months);

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }

    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if (Balance > 0 && Balance < 1000)
                return 0;
            return months * MonthlyInterestRate;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");
            Balance -= amount;
        }
    }

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate) { }

        public override decimal CalculateInterest(int months)
        {
            int gracePeriod = Customer is Individual ? 3 : 2;
            int chargeableMonths = Math.Max(0, months - gracePeriod);
            return chargeableMonths * MonthlyInterestRate;
        }
    }

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if (Customer is Individual)
            {
                int gracePeriod = 6;
                int chargeableMonths = Math.Max(0, months - gracePeriod);
                return chargeableMonths * MonthlyInterestRate;
            }
            else // Company
            {
                int reducedRateMonths = Math.Min(12, months);
                int fullRateMonths = Math.Max(0, months - 12);
                return (reducedRateMonths * MonthlyInterestRate / 2) + (fullRateMonths * MonthlyInterestRate);
            }
        }
    }
}