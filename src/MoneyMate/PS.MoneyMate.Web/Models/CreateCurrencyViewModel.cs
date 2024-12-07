﻿namespace PS.MoneyMate.Web.Models
{
    public class CreateCurrencyViewModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
