using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models
{
    public class Jail
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string State { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string County { get; set; }
    }
}
