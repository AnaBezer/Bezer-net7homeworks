// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;

// Bubble Sort Algorithm

List<int> prices = new List<int> { 39, 22, 7, 20, 11, 28, 33 };


for (int counter = 0; counter < prices.Count - 1; counter++)
{
    for (int j = 0;  j < prices.Count - 1; j++)
    {
        if (prices[j] > prices[j + 1])
        { 
            int maxim = prices[j];

            prices[j] = prices[j + 1];
            prices[j + 1] = maxim;
        }
    }
}
 foreach (int price in prices)
{
    Console.WriteLine(price);
}


