using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TermProject.Models
{
    public class Product
    {
        public string SeasonId { get; set; } = string.Empty;
        [ValidateNever]
        public Season Season { get; set; } = null!;

        [Range(1,1000)]
        public int ProductId { get; set; }
        public int DesignerId { get; set; }
        public Designer Designer { get; set; } = null!;

        [StringLength(100)]
        [Required(ErrorMessage = "Please enter a name.")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string Name { get; set; } = string.Empty;

        [Range(1979,3000)]
        [Required(ErrorMessage = "Please enter a year.")]
        public int? Year { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Please enter a clothing type.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string Type { get; set; } = string.Empty;
    }
}
