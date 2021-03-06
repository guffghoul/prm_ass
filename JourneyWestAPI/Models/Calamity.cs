﻿using System;
using System.Collections.Generic;

namespace JourneyWestAPI.Models
{
    public partial class Calamity
    {
        public Calamity()
        {
            ActorList = new HashSet<ActorList>();
            EquipmentList = new HashSet<EquipmentList>();
        }

        public int CalamityId { get; set; }
        public string CalamityName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? NumberOfFilming { get; set; }
        public string RoleSpecification { get; set; }
        public int Status { get; set; }
        public bool? IsActive { get; set; }

        public virtual Status StatusNavigation { get; set; }
        public virtual ICollection<ActorList> ActorList { get; set; }
        public virtual ICollection<EquipmentList> EquipmentList { get; set; }
    }
}
