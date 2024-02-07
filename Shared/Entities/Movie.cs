using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.Entities
{
    public class Movie
    {
        public string? Title { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}