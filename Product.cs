using System;

public class Product
{
	public Product(string name, double price, int quanity)
	{
		this.name = name;
		this.price = price;
		this.quantity = quanity;
	}

	private string name;
	private double price;
	private int quantity;

	public string GetName()
	{
		return this.name;
	}

	public double GetPrice()
	{
		return this.price;
	}

	public int GetQuantity()
	{
		return this.quantity;
	}

	public string SetName(string newName)
	{
		return this.name = newName;
	}

	public double SetPrice(double newPrice)
	{
		return this.price = newPrice;
	}

	public int SetQuantity(int newQuantity)
	{
		return this.quantity = newQuantity;
	}
}
