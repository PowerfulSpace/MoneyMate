namespace PS.MoneyMate.Domain.Entities
{
    public class ExchangeRate
    {
        public string FromCurrency { get; set; } = null!;
        public string ToCurrency { get; set; } = null!;
        public decimal Rate { get; set; }
    }
}
