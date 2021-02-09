using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models
{
    public class Bond
    {
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
    }
}
