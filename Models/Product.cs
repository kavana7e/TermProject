using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TermProject.Models
{
    public class Product
    {
        public string SeasonId { get; set; } = string.Empty;
        [ValidateNever]
        public Season Season { get; set; } = null!;

        public int ProductId { get; set; }
        public int DesignerId { get; set; }
        public Designer Designer { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a year.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a clothing type.")]
        public string Type { get; set; } = string.Empty;
    }
}
