using System;
using System.Collections.Generic;

#nullable disable

namespace EDMCrud.EDM
{
    public partial class Tblemployee
    {
        public int EmpId { get; set; }
        public string FName { get; set; }
        public int? Salary { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string Hobbies { get; set; }
        public string Profileimg { get; set; }

        public virtual Tblcity City { get; set; }
        public virtual Tblstate State { get; set; }
    }
}
