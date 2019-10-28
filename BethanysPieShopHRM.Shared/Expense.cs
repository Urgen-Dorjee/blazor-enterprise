﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopHRM.Shared
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string ExpenseType {get; set;}

    }
}
