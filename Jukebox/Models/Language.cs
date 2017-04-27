using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jukebox.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Track> Tracks  { get; set; }
   
    }
}