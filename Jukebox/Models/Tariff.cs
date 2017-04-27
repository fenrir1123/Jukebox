using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jukebox.Models
{
    public class Tariff
    {
        public int TariffId { get; set; }
        public string TariffName { get; set; }
        public decimal Price { get; set; }
        public decimal ShiftingPrice { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }

        public virtual ICollection<CurrentTariff> CurrentTariffs { get; set; }
    }
}