using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class Director
    {
        [Key] public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
    }
}