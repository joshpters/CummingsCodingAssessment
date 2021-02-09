using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models
{
    public class RequestingAgency
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        public string State { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string County { get; set; }
    }
}
