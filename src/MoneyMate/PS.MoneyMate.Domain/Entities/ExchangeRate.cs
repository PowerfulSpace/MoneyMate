namespace PS.MoneyMate.Domain.Entities
{
    public class ExchangeRate
    {
        public string FromCurrency { get; set; } = null!; // Исходная валюта (например, USD).
        public string ToCurrency { get; set; } = null!; // Целевая валюта (например, EUR).
        public decimal Rate { get; set; } // Курс обмена.

        public DateTime RetrievedAt { get; set; } // Дата и время получения курса.
    }
}
