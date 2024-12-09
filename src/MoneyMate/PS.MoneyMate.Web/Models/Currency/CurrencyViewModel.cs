﻿namespace PS.MoneyMate.Web.Models.Currency
{
    public class CurrencyViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
