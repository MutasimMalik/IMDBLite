using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IMDBlite.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Name is required")]
        public string Name { get; set; }
        public List<MoviesGenres> MoviesGenres { get; set; } = new List<MoviesGenres>();
    }
}
