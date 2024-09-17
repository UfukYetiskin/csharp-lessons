//Validations için gerekli kütüphane
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        //ya da
        //[Required(ErrorMessage= "Ad alanı zorunludur!")]
        public string? Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email alanı zorunludur!")]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }
 
        [Required]
        public bool WillAttend { get; set; }
    }
}