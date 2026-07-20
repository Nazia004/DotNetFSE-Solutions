using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Department { get; set; } = string.Empty;

        public decimal Salary { get; set; }
    }
}