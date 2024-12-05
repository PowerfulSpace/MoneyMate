namespace PS.MoneyMate.Domain.Entities
{
    internal class ConversionRequest
    {
        public string FromCurrency { get; set; } = null!; // Исходная валюта.
        public string ToCurrency { get; set; } = null!; // Целевая валюта.
        public decimal Amount { get; set; } // Сумма для конвертации.
        public DateTime RequestedAt { get; set; } // Время запроса.
    }
}
