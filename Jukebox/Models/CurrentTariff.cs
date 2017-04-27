using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jukebox.Models
{
    public class CurrentTariff
    {
        public int CurrentId { get; set; }
        public DateTime WokrDate { get; set; }
        public string TariffName { get; set; }

        public virtual Tariff Tariff { get; set; }
    }
}