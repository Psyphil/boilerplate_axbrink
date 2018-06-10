using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Public.Models
{
    public class Meeting
    {
        [Key]
        public int MeetingID { get; set; }
        public int OrganisationID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string MeetingTitle { get; set; }
        public DateTime MeetingDate { get; set; }
        public int MeetingDuration { get; set; }

        public List<MeetingItem> MeetingItems { get; set; }
        public List<IdentityUser> Members { get; set; }
    }
}
