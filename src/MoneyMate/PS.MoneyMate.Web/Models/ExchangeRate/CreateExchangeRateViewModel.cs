namespace PS.MoneyMate.Web.Models.ExchangeRate
{
    public class CreateExchangeRateViewModel
    {
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Rate { get; set; }
    }
}
