using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bills.Models
{
    public class Film
    {
        public string FilmName { get; set; }

        public int Id { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Seans> Seans { get; set; }
        public string image { get; set; }

        public Film()
        {
            Seans = new List<Seans>();
        }
    }
}
