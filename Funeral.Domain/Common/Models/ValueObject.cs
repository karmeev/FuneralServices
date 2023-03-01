namespace Funeral.Domain.Common.Models;

public class Price
{
    public decimal Amount {get; private set; }
    public string Currency {get; private set; }

     public Price(decimal amount, string currency)
     {
         Amount = amount;
         Currency = currency;
     }
}