using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beaver.Models
{
    public class Video
    {
        public int ID { get; set; } // Id will uniquely identify each video. Unlike Ruby needs to be explicitly set
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; } // Reference type - presume we will make a Genre class

    }
    public enum Genre
    {
        Comedy = 1,
        Horror,
        Scifi,
        Romance,
        Documentary,
        Kids
    }
}