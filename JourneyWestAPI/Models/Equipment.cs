using System;
using System.Collections.Generic;

namespace JourneyWestAPI.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            EquipmentList = new HashSet<EquipmentList>();
        }

        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<EquipmentList> EquipmentList { get; set; }
    }
}
