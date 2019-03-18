using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int ProfileId { get; set; }

        public void SetProfileId(int profileId)
        {
            ProfileId = profileId;
        }

        public int GetProfileId()
        {
            return ProfileId;
        }

        public int GetProfileId(ApplicationUser user)
        {
            return ProfileId;
        }
    }
}
