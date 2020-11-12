using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteAspNetCoreDemo
{
    public class TeamMembership
    {
        public int TeamMembershipId { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string Role { get; set; }
    }
}
