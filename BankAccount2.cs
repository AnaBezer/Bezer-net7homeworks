using System;

public class BankAccount2
{
    public BankAccount2(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.Balance = balance;
    }

    private int accountNumber;
    private string accountHolder;

    public int AccountNumber { get; set; }
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public void Deposit(double value)
    {
        if (this.Balance < 0)
        {
            throw new Exception("The deposit amount is negative");
        }

        this.Balance = this.Balance + value;
    }

    public void Withdraw(double value)
    {
        if (value > this.Balance)
        {
            throw new Exception("The withdraw amount must be lower or equal to the balance amount");
        }

        this.Balance = this.Balance - value;
    }

    public double GetInterest()
    {
        return Bank.CalculateInterest(this.Balance);
    }

}
