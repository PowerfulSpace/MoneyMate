namespace PS.MoneyMate.Web.Models
{
    public class UpdateExchangeRateViewModel
    {
        public Guid Id { get; set; }
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Rate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
