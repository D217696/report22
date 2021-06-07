using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class ActivityPage
    {
        public int Id { get; set; }
        public string Json { get; set; }
        public string CharacterId { get; set; }
        public string MembershipId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
    }
}
