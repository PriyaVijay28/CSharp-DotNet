using System.ComponentModel.DataAnnotations;

namespace DoctorManagement.Models
{
    public class DM
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Speciality { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }

        
    }
}
