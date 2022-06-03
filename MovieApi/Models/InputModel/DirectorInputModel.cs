using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models.InputModel
{
    public class DirectorInputModel
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
    }
}