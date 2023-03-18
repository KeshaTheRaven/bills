using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bills.Models
{
    public class Zal
    {
        public string ZalName { get; set; }
        public virtual ICollection<Seans> Seans { get; set; }
        public Zal() 
        {
            Seans = new List<Seans>();
        }
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public virtual Cinema cinema { get; set; }
    }
}
