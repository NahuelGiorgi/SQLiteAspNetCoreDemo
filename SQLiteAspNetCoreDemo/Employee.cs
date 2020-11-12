using System.Collections.Generic;

namespace SQLiteAspNetCoreDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual List<TeamMembership> TeamMembership { get; set; }
    }
}
