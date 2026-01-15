using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        // Initialize Movies to avoid null reference in the view
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public SelectList? Genres { get; set; }

        public string? MovieGenre { get; set; }

        public string? SearchString { get; set; }

        public int? MovieYear { get; set; }
    }
}