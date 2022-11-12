using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace MyWebApp.Models
{
    public class Student
    {
        [Required]
        public int StdID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter the Student Name")]
        [StringLength(30, ErrorMessage = "Please enter less than 30 characters")]
        
public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter the Student Address")]
        [StringLength(30, ErrorMessage = "Please enter less than 30 characters")]
        public string Address { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter the Student Faculty")]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Enter the Student Phone Number")]
        public long PhoneNo { get; set; }
    }
}