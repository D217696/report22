using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class GetProfileResponse
    {
        public List<Profile> Profiles { get; set; } = new();
        public User User { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
