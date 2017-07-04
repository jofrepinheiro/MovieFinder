using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Domain.Settings
{
    public class MovieAPISettings
    {
        static string apiKey = "dd3cc3bd7fa6542c91bf1aee810ee806";

        public static string GetURL(string movie)
        {

            string resource = String.Format("https://api.themoviedb.org/3/search/movie?api_key={0}&language={1}&query={2}", 
                                            apiKey, "pt-BR", movie);

            return resource;
        }
    }
}
