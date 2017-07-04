using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Domain.Models
{
    public class DTOMovie
    {
        public Results results { get; set; }
    }
    public class Results
    {
        public int id { get; set; }
        public string title { get; set; }
        public string original_title { get; set; }
        public DateTime release_date { get; set; }
        public string overview { get; set; }
    }
}
