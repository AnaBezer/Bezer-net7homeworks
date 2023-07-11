using System;

public class Drug
{
    public Drug (string name, double price, int quantity, bool needsPrescription)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.needsPrescription = needsPrescription;
    }

    public string name;
    public double price;
    public int quantity;
    public bool needsPrescription;

    public string Sell(int amount)
    {
        if (this.needsPrescription == true)
        {
            return $"{name} is sold by prescription";
        }

        if (amount > this.quantity)
        {
            return $"You're trying to buy {amount} of {this.name}, unfortunately, there is only {this.quantity} available";
            
        }

        this.quantity = this.quantity - amount;

        return $"You just purchased {amount} of {this.name}, amount left : {this.quantity}";
    }
}
