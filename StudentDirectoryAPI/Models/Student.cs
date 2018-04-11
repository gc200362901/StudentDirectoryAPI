using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDirectoryAPI.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public String City { get; set; }

        [Required]
        public String Province { get; set; }

        [Required]
        public String Postal { get; set; }

        [Required]
        public String Phone { get; set; }

    }
}
