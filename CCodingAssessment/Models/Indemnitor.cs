using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CCodingAssessment.Data.Enums;

namespace CCodingAssessment.Models
{
    public class Indemnitor
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]

        public string LastName { get; set; }
        [StringLength(50)]
        public string AliasName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Ethnicity Ethnicity { get; set; }
        public string SSN { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

    }
}
