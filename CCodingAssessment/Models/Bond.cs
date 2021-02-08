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
        public decimal Amount { get; set; }
        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; }
    }
}
