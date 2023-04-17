using System.ComponentModel.DataAnnotations;

namespace FreeTicketz.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
