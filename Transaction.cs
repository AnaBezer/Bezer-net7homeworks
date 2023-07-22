using System;

public class Transaction
{
	public Transaction(double amount, string type)
	{
		this.Type = type;
		this.Amount = amount;
		this.Timestamp = DateTime.Now;
    }
	public DateTime Timestamp { get; }
	public string Type { get; }
	public double Amount { get; }
}
