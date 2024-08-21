public class CurrencyConverter
{
    
    public string FromCurrency { get; set; }
    public string ToCurrency { get; set; }
    public double ExchangeRate { get; set; }

   
    private static int ConversionCount { get; set; } = 0;

    
    public CurrencyConverter(string fromCurrency, string toCurrency, double exchangeRate)
    {
        FromCurrency = fromCurrency;
        ToCurrency = toCurrency;
        ExchangeRate = exchangeRate;
    }

   
    public static void ShowConversionCount()
    {
        Console.WriteLine($"Total conversions: {ConversionCount}");
    }

   
    private static void IncrementConversionCount()
    {
        ConversionCount++;
    }

   
    public double ConvertAmount(double amount)
    {
        IncrementConversionCount();
        return amount * ExchangeRate;
    }

   
    public double ConvertAmount(double amount, double customRate)
    {
        IncrementConversionCount();
        return amount * customRate;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        CurrencyConverter usdToInr = new CurrencyConverter("USD", "INR", 74.85);
        CurrencyConverter eurToUsd = new CurrencyConverter("EUR", "USD", 1.18);

        double amountInInr = usdToInr.ConvertAmount(100);
        double amountInUsd = eurToUsd.ConvertAmount(100);

        
        double customAmountInInr = usdToInr.ConvertAmount(100, 75.00);
        double customAmountInUsd = eurToUsd.ConvertAmount(100, 1.20);

       
        Console.WriteLine($"100 USD to INR (default rate): {amountInInr}");
        Console.WriteLine($"100 EUR to USD (default rate): {amountInUsd}");
        Console.WriteLine($"100 USD to INR (custom rate): {customAmountInInr}");
        Console.WriteLine($"100 EUR to USD (custom rate): {customAmountInUsd}");

        
        CurrencyConverter.ShowConversionCount();
    }
}