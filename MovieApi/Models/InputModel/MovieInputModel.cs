using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models.InputModel
{
    public class MovieInputModel
    {
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