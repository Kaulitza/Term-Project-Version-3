using System;
using System.ComponentModel.DataAnnotations;

namespace Term_Project_Version_1.Models
{
    public class Members
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Please enter your full name using 30 characters or less.")]
        public string name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Please enter your e-mail address using 50 characters or less.")]
        public string email { get; set; }
    }
}