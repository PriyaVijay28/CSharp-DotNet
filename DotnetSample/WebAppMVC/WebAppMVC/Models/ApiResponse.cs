namespace WebAppMVC.Models
{
    public class ApiResponse
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public List<PostalCode> PostOffice { get; set; }
    }
}
