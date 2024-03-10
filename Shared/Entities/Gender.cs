using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.Entities
{
    public class Gender
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The {0} field is required...")]
        public string Name { get; set; }
    }
}