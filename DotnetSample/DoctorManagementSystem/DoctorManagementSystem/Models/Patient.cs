using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoctorManagementSystem.Models
{
    public class Patient
    {
        [Key]
        public int PId { get; set; }
        public string? PatientName { get; set; }
        public int? Age { get; set; }
        public string? Specialist { get; set; }

        [ForeignKey("DMS")]
        public int? DId { get; set; }
    }
}
