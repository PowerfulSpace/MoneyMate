namespace PS.MoneyMate.Domain.Entities
{
    public class Currency
    {
        public string Code { get; set; }= null!; // Код валюты, например, USD, EUR.
        public string Name { get; set; } = null!; // Название валюты, например, "Доллар США".
        public string Symbol { get; set; } = null!; // Символ валюты, например, "$".
    }
}
