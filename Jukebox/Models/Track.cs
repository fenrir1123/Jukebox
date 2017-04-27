using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jukebox.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public decimal Duration { get; set; }
        public int GenreId { get; set; }
        public int SingerId { get; set; }
        public int LanguageId { get; set; }

        public virtual ICollection<Order> Orders {get;set;}
        public virtual Genre Genre { get; set; }
        public virtual Singer Singer { get; set; }
        public virtual Language Languade { get; set; }

    }
}