using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieApi.Models
{
    public class Director
    {
        [Key] public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        
        [JsonIgnore]
        public virtual Movie Movie { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}