using System;

public static class Bank
{
    public static double InterestRate { get; set; } = 0.01;
    public static int NumAccounts { get; set; } = 0;

    public static double CalculateInterest(double balance)
    {
        return balance * InterestRate;
    }

    public static int GetNumAccounts()
    {
        return NumAccounts;
    }
}
