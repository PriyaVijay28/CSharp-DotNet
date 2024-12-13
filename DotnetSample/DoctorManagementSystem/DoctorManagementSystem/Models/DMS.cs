using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DoctorManagementSystem.Models
{
    public class DMS
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Qualification { get; set; }
        [Required]
        public string? Speciality { get; set; }
    }
}
