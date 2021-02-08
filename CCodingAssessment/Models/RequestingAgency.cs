using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCodingAssessment.Models
{
    public class RequestingAgency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string County { get; set; }
    }
}
