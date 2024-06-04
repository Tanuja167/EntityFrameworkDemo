using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]

        public int Id { get; set; }
        [Required]

        public string Sname { get; set; }
        [Required]

        public int Spercentage { get; set;}
        [Required]

        public string City { get; set;}

    }
}
