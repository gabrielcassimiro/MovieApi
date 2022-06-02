using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApi.Models
{
    public class Movie
    {
        [Key] public int Id { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Title Description is required.")]
        public string Description { get; set; }

        public int DirectorId { get; set; }

        [Required(ErrorMessage = "The Title Genre is required.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "The Title Duration is required.")]
        public int Duration { get; set; }
    }
}