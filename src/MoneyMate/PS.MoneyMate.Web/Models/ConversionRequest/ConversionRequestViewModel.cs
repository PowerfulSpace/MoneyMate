namespace PS.MoneyMate.Web.Models.ConversionRequest
{
    public class ConversionRequestViewModel
    {
        public Guid Id { get; set; }
        public Guid FromCurrencyId { get; set; }
        public string FromCurrencyCode { get; set; } = string.Empty; // Для отображения кода валюты
        public Guid ToCurrencyId { get; set; }
        public string ToCurrencyCode { get; set; } = string.Empty; // Для отображения кода валюты
        public decimal Amount { get; set; }
        public decimal ConvertedAmount { get; set; }
        public DateTime ConversionDate { get; set; }
    }
}
