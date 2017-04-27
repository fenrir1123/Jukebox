using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Jukebox.Models;

namespace Jukebox.DAL
{
    public class DbInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<JukeBoxContext>
    {
        protected override void Seed (JukeBoxContext context)
        {
            var genres = new List<Genre>
            {
                new Genre { GenreId=1,Name="Pop"},
                new Genre { GenreId=2,Name="Jazz"},
                new Genre { GenreId=3,Name="Opera"},
                new Genre { GenreId=4,Name="Alternative"},
                new Genre { GenreId=5,Name="Blues"},
                new Genre { GenreId=6,Name="Country"},
                new Genre { GenreId=7,Name="Dance Music"},
                new Genre { GenreId=8,Name="Classic"},
                new Genre { GenreId=9,Name="Rock"},
                new Genre { GenreId=10,Name="Rap"},
            };
            var languages = new List<Language>
            {
                new Language { LanguageId=1,Name="Russian" },
                new Language { LanguageId=1,Name="English" },
                new Language { LanguageId=1,Name="Ukranian" },
                new Language { LanguageId=1,Name="French" },
                new Language { LanguageId=1,Name="Italian" },
            };
            var singers = new List<Singer>
            {
                new Singer { SingerId=1,Name="Madonna" },
                new Singer { SingerId=2,Name="Armstrong" },
                new Singer { SingerId=3,Name="Mozart" },
                new Singer { SingerId=4,Name="Linking Park" },
                new Singer { SingerId=5,Name="Ray Charles" },
                new Singer { SingerId=6,Name="Teilor Svifft" },
                new Singer { SingerId=7,Name="Armin van Buren" },
                new Singer { SingerId=8,Name="Bah" },
                new Singer { SingerId=9,Name="AC/DC" },
                new Singer { SingerId=10,Name="Eminem" },
            };
            var tracks = new List<Track>
            {
                new Track { TrackId=1,Duration=3,GenreId=1,SingerId=1,LanguageId=1},
                new Track { TrackId=2,Duration=3,GenreId=2,SingerId=2,LanguageId=2},
                new Track { TrackId=3,Duration=3,GenreId=3,SingerId=3,LanguageId=3},
                new Track { TrackId=4,Duration=3,GenreId=4,SingerId=4,LanguageId=4},
                new Track { TrackId=5,Duration=3,GenreId=5,SingerId=5,LanguageId=5},
                new Track { TrackId=6,Duration=3,GenreId=6,SingerId=6,LanguageId=1},
                new Track { TrackId=7,Duration=3,GenreId=7,SingerId=7,LanguageId=2},
                new Track { TrackId=8,Duration=3,GenreId=8,SingerId=8,LanguageId=3},
                new Track { TrackId=9,Duration=3,GenreId=9,SingerId=9,LanguageId=4},
                new Track { TrackId=10,Duration=3,GenreId=10,SingerId=10,LanguageId=5},
            };
            var orders = new List<Order>
            {
                new Order { OrderId=1,TrackId=2,TableNumber=1,Executing=true,ShiftingCount=0,OrderPrice=0.1m,OrderDate=DateTime.Parse("03-03-2017"),OrderTime=DateTime.Parse("14:56"),LastTime=DateTime.Parse("14:56")},
                new Order { OrderId=2,TrackId=5,TableNumber=3,Executing=false,ShiftingCount=0,OrderPrice=0.1m,OrderDate=DateTime.Parse("03-03-2017"),OrderTime=DateTime.Parse("14:56"),LastTime=DateTime.Parse("14:56")},
                new Order { OrderId=3,TrackId=6,TableNumber=2,Executing=false,ShiftingCount=0,OrderPrice=0.1m,OrderDate=DateTime.Parse("03-03-2017"),OrderTime=DateTime.Parse("14:56"),LastTime=DateTime.Parse("14:56")},
            };
            var queueshifts = new List<QueueShift>
            {
                new QueueShift { QueueShiftId=1,OrderId=1,Shifts=0,Price=0.1m,ShiftTime=DateTime.Parse("")}
            };
            var tariffs = new List<Tariff>
            {
                new Tariff { TariffId=1,TariffName="ferial",Price=0.1m,ShiftingPrice=0.1m,TimeBegin=DateTime.Parse("9:00:00"),TimeEnd=DateTime.Parse("13:00:00")},
                new Tariff { TariffId=2,TariffName="day-off",Price=0.2m,ShiftingPrice=0.2m,TimeBegin=DateTime.Parse("9:00:00"),TimeEnd=DateTime.Parse("13:00:00")},
                new Tariff { TariffId=3,TariffName="ferial",Price=0.2m,ShiftingPrice=0.1m,TimeBegin=DateTime.Parse("13:00:00"),TimeEnd=DateTime.Parse("18:00:00")},
                new Tariff { TariffId=4,TariffName="day-off",Price=0.3m,ShiftingPrice=0.2m,TimeBegin=DateTime.Parse("13:00:00"),TimeEnd=DateTime.Parse("18:00:00")},
                new Tariff { TariffId=5,TariffName="ferial",Price=0.2m,ShiftingPrice=0.2m,TimeBegin=DateTime.Parse("18:00:00"),TimeEnd=DateTime.Parse("00:00:00")},
                new Tariff { TariffId=6,TariffName="day-off",Price=0.3m,ShiftingPrice=0.3m,TimeBegin=DateTime.Parse("18:00:00"),TimeEnd=DateTime.Parse("00:00:00")},
            };
            var currenttariff = new List<CurrentTariff>
            {
                new CurrentTariff { CurrentId=1,WokrDate=DateTime.Parse("03-03-2017 9:00:00"),TariffName="ferial"},
            };
        }

    }
}