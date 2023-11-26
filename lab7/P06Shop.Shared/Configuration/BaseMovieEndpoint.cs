using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Configuration
{
    public class BaseMovieEndpoint
    {
        public string Base_url { get; set; }
        public string GetAllMoviesEndpoint { get; set; }
        public string SearchMoviesEndpoint { get; set; }
    }
}
