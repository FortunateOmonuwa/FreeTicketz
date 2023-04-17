using FreeTicketz.Data.Enums;

namespace FreeTicketz.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; } 
    }
}
