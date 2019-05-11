using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    public class Movie
    {

        public int Id { get; set; }
        //[Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Title { get; set; }
        public int Runtime { get; set; }
        public double Rating { get; set; }
        public string Storyline { get; set; }
    }
}
