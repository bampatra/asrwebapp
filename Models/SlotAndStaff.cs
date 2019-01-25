using System;
using System.Collections.Generic;

namespace ASRWebApp.Models
{
    public class SlotAndStaff
    {
        public IEnumerable<Slot> Slots { get; set; }
        public IEnumerable<Staff> Staffs { get; set; }
 
    }
}
