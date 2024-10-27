using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProject.Models
{
    public class Designer
    {
        [Display(Name = "Designer ID")]
        [Range(1,1000)]
        public int DesignerId { get; set; }

        [StringLength(35)]
        [Column("First Name")]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; }

        [StringLength(35)]
        [Column("Last Name")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; }

        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }
    }
}
