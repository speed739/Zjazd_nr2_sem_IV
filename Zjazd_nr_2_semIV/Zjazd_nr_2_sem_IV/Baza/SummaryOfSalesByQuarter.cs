using System;
using System.Collections.Generic;

namespace Zjazd_nr_2_sem_IV.Baza
{
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
