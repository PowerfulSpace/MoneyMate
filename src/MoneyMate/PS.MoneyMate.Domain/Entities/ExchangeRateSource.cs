namespace PS.MoneyMate.Domain.Entities
{
    public class ExchangeRateSource
    {
        public string Name { get; set; } = null!; // Название источника (например, "Open Exchange Rates").
        public string Url { get; set; } = null!; // URL-адрес API или веб-ресурса.
    }
}
