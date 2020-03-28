using System;
using System.Collections.Generic;

namespace Zjazd_nr_2_sem_IV.Baza
{
    public partial class SalesByCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
