using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bills.Models
{
    public class Seans
    {
        public int Id { get; set; }
        public int ZalId { get; set; }
        public virtual Zal Zal { get; set; }

        public int Cost { get; set; }

        public int FilmId { get; set; }

        public virtual Film Film { get; set; }

        public DateTime Date { get; set; }
    }
}
