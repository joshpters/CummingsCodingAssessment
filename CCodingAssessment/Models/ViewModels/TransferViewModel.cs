using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models.ViewModels
{
    public class TransferViewModel
    {
        public ProvidingAgency ProvidingAgency { get; set; }
        public RequestingAgency RequestingAgency { get; set; }
        public Defendant Defendant { get; set; }
        public Bond Bond { get; set; }
        public Jail Jail { get; set; }
        public Indemnitor Indemnitor { get; set; }
        [MaxLength(500)]
        public string AdditionalInformation { get; set; }
        [Required]
        public bool AgreedToTerms { get; set; }
    }
}
