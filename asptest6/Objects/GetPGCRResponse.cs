using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class GetPGCRResponse
    {
        public CharacterPgcr CharacterPgcr { get; set; }
        public Pgcr Pgcr { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
