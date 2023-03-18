using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bills.Models
{
    public class BillDataModel : DbContext
    {
        public BillDataModel() 
            :base("name=BillDataModel")
        {

        }

        public virtual DbSet<Seans> Seanses { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Zal> Zals { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
    }
    

    

    

    
}
