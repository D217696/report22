using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class GetCharacterPagesResponse
    {
        public List<CharacterPage> Characters { get; set; } = new List<CharacterPage>();
    }

    public class CharacterPage
    {
        public string CharacterId { get; set; }
        public int Pages { get; set; }
        public int Count { get; set; }
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
    }

    public class CharacterPageRequest
    {
        public string CharacterId { get; set; }
        public int Pages { get; set; }
        public int Count { get; set; }
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
        public List<ActivityPage> ActivtityPages { get; set; } = new List<ActivityPage>();
    }
}
