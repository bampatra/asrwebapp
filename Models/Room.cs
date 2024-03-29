﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASRWebApp.Models
{
    public class Room
    {
        [Required]
        public string RoomID { get; set; }

        public virtual ICollection<Slot> Slots { get; set; }
    }
}
