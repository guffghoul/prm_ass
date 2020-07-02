using System;
using System.Collections.Generic;

namespace JourneyWestAPI.Models
{
    public partial class User
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public int? ActorId { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
