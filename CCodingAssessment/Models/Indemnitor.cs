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

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AliasName { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Ethnicity Ethnicity { get; set; }
        public string SSN { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

    }
}
