using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Shared.Entities;

namespace BlazorMovies.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        public string? Resume { get; set; }
        public bool InTheater { get; set; }
        public string? Trailer { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string? Poster { get; set; }
        public List<GenrerMovie> GenrerMovie { get; set; } 
            = new List<GenrerMovie>();
        public string? ShortTitle 
        { 
            get
            {
                if(string.IsNullOrWhiteSpace(Title))
                {
                    return null;
                }
                if (Title.Length > 60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }
    }
}