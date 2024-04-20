using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeansTakip.Models
{
    public class Film
    {
        public int id { get; set; }
        public string filmAdi { get; set; }
    }

    public class Salon
    {
        public int id { get; set; }
        public int SalonKapasite { get; set; }
        public string SalonAdi { get; set; }

    }

    public class Seans
    {
        public int id { get; set; }
        public string tarih { get; set; }
        public string saat { get; set; }


        public int filmId { get; set; }
        public int salonId { get; set; }
    }

    public class Rezervasyon
    {
        public int id { get; set; }
        public string koltukNo { get; set; }
        public int seansId { get; set; }
    }
}