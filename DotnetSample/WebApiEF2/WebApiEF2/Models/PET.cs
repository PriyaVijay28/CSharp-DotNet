using System.ComponentModel.DataAnnotations;

namespace WebApiEF2.Models
{
    public class PET
    {
        [Key]
        public int  PId { get; set; }
        public string? PName { get; set; }
        public string? PType { get; set; }
        public string? DOB { get; set; }
        public bool isVeg { get; set; }
    }
}
