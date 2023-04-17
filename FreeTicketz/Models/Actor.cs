using System.ComponentModel.DataAnnotations;

namespace FreeTicketz.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string PictureURL { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Biography { get; set; }
    }
}
