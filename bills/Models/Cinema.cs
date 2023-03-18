using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bills.Models
{
    public class Cinema
    {
        public string CinemaName { get; set; }
        public int Id { get; set; }
        public string Adresse { get; set; }
        public virtual ICollection<Zal> Zals { get; set; }
        public Cinema()
        { 
            Zals = new List<Zal>();
        }
    }
}
