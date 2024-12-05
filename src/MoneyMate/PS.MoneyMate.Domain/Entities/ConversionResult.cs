
namespace PS.MoneyMate.Domain.Entities
{
    internal class ConversionResult
    {
        public decimal OriginalAmount { get; set; } // Исходная сумма.
        public string FromCurrency { get; set; } = null!; // Исходная валюта.
        public decimal ConvertedAmount { get; set; } // Конвертированная сумма.
        public string ToCurrency { get; set; } = null!;// Целевая валюта.
        public decimal ExchangeRate { get; set; } // Курс обмена.
        public DateTime ConversionTime { get; set; } // Время конвертации.
    }
}
