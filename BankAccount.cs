using System;

public class BankAccount
{
	public BankAccount(int accountNumber, string accountHolder, double balance)
	{
		this.AccountHolder = accountHolder;
		this.Balance = balance;
		this.AccountNumber = accountNumber;

        this.transactions = new List<Transaction>();
    }
	public int AccountNumber { get; set; }

	public string AccountHolder { get; set; }
	private double Balance { get; set; }
	private List<Transaction> transactions { get; set; }

	public void Deposit(double Amount)
	{

        if (Amount <= 0)
		{
			throw new Exception("Deposit amount must be greater than zero.");
		}

		this.Balance += Amount;
		Transaction NewTransaction = new Transaction(Amount, "deposit");
		this.transactions.Add(NewTransaction);
    }

	public void Withdraw(double Amount)
	{
		if (Amount <= 0)
		{
            throw new Exception("Deposit amount must be greater than zero.");
		}

		if (this.Balance <= Amount)
		{
			throw new Exception("The withdraw amount must be equal or lower than the deposit amount");
		}

        this.Balance -= Amount;
		Transaction NewTransaction = new Transaction(Amount, "withdraw");
		this.transactions.Add(NewTransaction);
	}

	public double GetBalance()
	{
		return this.Balance;
	}

	public List<Transaction> GetTransactionHistory()
	{
		return this.transactions.OrderBy(Transaction => Transaction.Timestamp).ToList();
	}

}
