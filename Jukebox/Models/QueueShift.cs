using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jukebox.Models
{
    public class QueueShift
    {
        public int QueueShiftId { get; set; }
        public int OrderId { get; set; }
        public int Shifts { get; set; }
        public decimal Price { get; set; }
        public DateTime ShiftTime { get; set; }

        public virtual Order Order{ get; set; }

    }
}