using asptest6.Objects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Api
{
    [Route("api/[controller]", Name = nameof(ProfileController))]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpPost]
        public async Task<List<Profile>> PostProfile(List<Profile> profiles)
        {
            return profiles;
        }
    }
}
