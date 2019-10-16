using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required ]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Display(Name = "MiddleName")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        public string DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Score")]
        public int Score { get; set; }

        [Display(Name = "Grade")]
        public string Grade { get; set; }

        [Display(Name = "Student No")]
        public int StudentNo { get; set; }

        [Display(Name ="Course")]
        public string Course { get; set; }
    }
}
