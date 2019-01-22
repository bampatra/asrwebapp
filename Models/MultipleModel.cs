using System;
using System.Collections.Generic;

namespace ASRWebApp.Models
{
    public class MultipleModel
    {
        // A class to pass two models at the same time
        public IEnumerable<Slot> Slots { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
    }
}
