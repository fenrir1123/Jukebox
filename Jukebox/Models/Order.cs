using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Jukebox.Models;

namespace Jukebox.Models
{
    public class Order
    {
       public int OrderId { get; set; }
       public int TrackId { get; set; }
       public int TableNumber { get; set; }
       public bool Executing { get; set; }
       public int ShiftingCount { get; set; }
       public decimal OrderPrice { get; set; }
       public DateTime OrderDate { get; set; }
       public DateTime OrderTime { get; set; }
       public DateTime LastTime { get; set; }

       public ICollection<QueueShift> QueueShifts { get; set; }
    
       public virtual  Track Track { get; set; }

    }
}