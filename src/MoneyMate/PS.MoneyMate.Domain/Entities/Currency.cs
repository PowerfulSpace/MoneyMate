namespace PS.MoneyMate.Domain.Entities
{
    public class Currency
    {
        public string Code { get; set; } = null!;// Код валюты (например, USD)
        public string Name { get; set; } = null!; // Название валюты
    }
}
