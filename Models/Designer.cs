using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class Designer
    {
        [Display(Name = "Designer ID")]
        public int DesignerId { get; set; }
        public string? Name { get; set; }
    }
}
