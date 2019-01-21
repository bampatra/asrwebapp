using System;
using System.ComponentModel.DataAnnotations;

namespace ASRWebApp.Models
{
    public class Student
    {
        [Required]
        public string StudentID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
