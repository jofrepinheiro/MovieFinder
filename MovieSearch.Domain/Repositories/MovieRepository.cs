using MovieSearch.Domain.Models;
using MovieSearch.Domain.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Domain.Repositories
{
    public class MovieRepository
    {
        private string url;

        public MovieRepository(string movieName)
        {
            url = MovieAPISettings.GetURL(movieName);
        }


        public async Task<DTOMovie> GetMovie()
        {
            DTOMovie movie = null;

            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);
                await Task.Run(() =>
                {
                    movie = JsonConvert.DeserializeObject<DTOMovie>(json);
                });
            }


            return movie;
        }



    }
}
