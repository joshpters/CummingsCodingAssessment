using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models
{
    public class ProvidingAgency
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Agent Name")]
        public string AgentName { get; set; }
        [Required]
        [StringLength(100)]
        public string Agency { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
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
