using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Jukebox.Models;

namespace Jukebox.DAL
{
    public class JukeBoxContext : DbContext
    {
        public JukeBoxContext() : base("JukeBoxContext")
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<QueueShift> Queue_Shifts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<CurrentTariff> CurrentTariffs { get; set; }


    }
}