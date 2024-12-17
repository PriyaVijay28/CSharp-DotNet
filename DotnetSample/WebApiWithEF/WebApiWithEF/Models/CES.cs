using System.ComponentModel.DataAnnotations;

namespace WebApiWithEF.Models
{
    public class CES
    {
        [Key]
        public int SId { get; set; }
        public string? SName { get; set; }
        public string? SDept { get; set; }
        public string? course1 { get; set; }
        public string? course2 { get; set; }

    }
}
