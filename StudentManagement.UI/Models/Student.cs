using System.ComponentModel.DataAnnotations;

namespace StudentManagement.UI.Models
{
    public class Student
    {
        [Key]
        [Display(Name="StudentId")]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }
    }
}
