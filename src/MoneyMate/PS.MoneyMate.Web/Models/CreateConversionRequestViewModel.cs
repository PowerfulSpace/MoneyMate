namespace PS.MoneyMate.Web.Models
{
    public class CreateConversionRequestViewModel
    {
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Amount { get; set; }
        public decimal ConvertedAmount { get; set; }
        public DateTime ConversionDate { get; set; } = DateTime.UtcNow;
    }
}
