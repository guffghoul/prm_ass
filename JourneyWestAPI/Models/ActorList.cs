using System;
using System.Collections.Generic;

namespace JourneyWestAPI.Models
{
    public partial class ActorList
    {
        public int ActorId { get; set; }
        public int CalamityId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Calamity Calamity { get; set; }
    }
}
