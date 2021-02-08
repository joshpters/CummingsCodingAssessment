using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models
{
    public class Transfer
    {
        public int Id { get; set; }

        public virtual RequestingAgency RequestingAgency { get; set; }
        public virtual ProvidingAgency ProvidingAgency { get; set; }
        public virtual Defendant Defendant { get; set; }
        public virtual Indemnitor Indemnitor { get; set; }
        public virtual Jail Jail { get; set; }
        public virtual Bond Bond { get; set; }

        public int ProvidingAgencyId { get; set; }
        public int JailId { get; set; }
        public int BondId { get; set; }
        public int RequestingAgencyId { get; set; }
        public int DefendantId { get; set; }
        public int IndemnitorId { get; set; }

        [MaxLength(500)]
        public string AdditionalInformation { get; set; }
        
    }
}
