using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Public.Models
{
    public class MeetingItem
    {
        public int MeetingID { get; set; }

        [Key]
        public int MeetingItemID { get; set; }
        public string MeetingItemTitle { get; set; }
        public string MeetingItemDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int MeetingItemStatus { get; set; }

        public Meeting Meeting { get; set; }
    }
}
