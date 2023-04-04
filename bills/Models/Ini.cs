using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace bills.Models
{
    class Ini : DropCreateDatabaseIfModelChanges<BillDataModel>
    {
        protected override void Seed(BillDataModel db)
        {
            
            

            Film f1 = new Film()
            {
                FilmName = "Пролетая на гнездом кукушки.",
                Id = 1,
                Duration = 65,
                ImagePath = @"Images\9da0fdd99fac16a0f238fec9cdb4fad1.jpeg",
                seans = new List<Seans>()
                {
                   new Seans()
                    {
                        Cost = 228,
                        Date = new DateTime(2002, 02, 02, 12, 12, 12),
                        ZalId = 1,

                    },new Seans()
                    {
                        Cost = 228,
                        Date = new DateTime(2002, 02, 02, 12, 12, 12),
                        ZalId= 2,

                    }
                }


            };

            Film f2 = new Film()
            {
                FilmName = "Форсаж",
                Id = 2,
                Duration = 65,
                ImagePath = @"Images\b86d5208a8f768fa5024e76546f8cd0c.jpeg",
                seans = new List <Seans>()
                {
                    new Seans()
                    {
                        Cost = 228,
                        Date = new DateTime(2002, 02, 02, 12, 12, 12),
                        ZalId= 2,

                    },
                    new Seans()
                    {
                        Cost = 228,
                        Date = new DateTime(2002, 01, 01, 12, 12, 12),
                        ZalId= 2,

                    }
                }
            };

            Film f3 = new Film()
            {
                FilmName = "Дом",
                Id = 3,
                Duration = 65,
                ImagePath = @"Images\looper-movie-poster-9r-2560x1600.jpg",
                seans= new List<Seans>()
                {
                    new Seans()
                    {
                        Cost = 228,
                        Date = new DateTime(2003, 03, 03, 12, 12, 12),
                        ZalId= 3,

                    },new Seans()
                    {
                        Cost = 228,
                        Date = new DateTime(2002, 02, 02, 12, 12, 12),
                        ZalId= 3,

                    }
                }
            };




            Zal z1 = new Zal()
            {
                ZalName = "1",
                Id = 1,

            };

            Zal z2 = new Zal()
            {
                ZalName = "2",
                Id = 2,
            };

            Zal z3 = new Zal()
            {
                ZalName = "3",
                Id = 3,
            };

            Zal z4 = new Zal()
            {
                ZalName = "1",
                Id = 4,

            };

            Zal z5 = new Zal()
            {
                ZalName = "2",
                Id = 5,
            };

            Zal z6 = new Zal()
            {
                ZalName = "3",
                Id = 6,
            };


            Cinema c1 = new Cinema()
            {
                CinemaName = "Москва",
                Adresse = "ул.Ленина",
                Zals = new List<Zal>()
                { z1,z2,z3 }
            };
            Cinema c2 = new Cinema()
            {
                CinemaName = "Kва",
                Adresse = "ул.Сталина",
                Zals = new List<Zal>()
                { z4,z5,z6 }
            };
            db.Cinemas.Add(c1);
            db.Cinemas.Add(c2);
            db.Films.Add(f1);
            db.Films.Add(f2);
            db.Films.Add(f3);
            db.SaveChanges();
        }
    }
    
}
