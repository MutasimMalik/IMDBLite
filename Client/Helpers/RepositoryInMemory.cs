using IMDBlite.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBlite.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Title = "Spider-Man: Far From Home", 
                    ReleaseDate = new DateTime(2019, 7, 2),
                    Poster = "https://i.ebayimg.com/images/g/1VkAAOSwrENdPb-R/s-l1600.jpg"
                },
                new Movie(){Title = "Moana", 
                    ReleaseDate = new DateTime(2016, 11, 23),
                    Poster = "https://www.arthipo.com/image/cache/catalog/genel-tasarim/all-posters/sinema-cinema-film-postersleri/yabanci-filmler/1/pfilm1042-moana-26hwy6-film-movie-posters-cinema-kanvas-tablo-canvas-1000x1000.jpg"
                },
                new Movie(){Title = "Inception", 
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Poster = "https://cdn.collider.com/wp-content/uploads/2010/06/inception-movie-poster-7.jpg"
                }
            };
        }
    }
}
