using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models
{
    public class ProvidingAgency
    {
        public int Id { get; set; }

        public string AgentName { get; set; }
        public string Agency { get; set; }
        public DateTime Date { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string County { get; set; }

    }
}
