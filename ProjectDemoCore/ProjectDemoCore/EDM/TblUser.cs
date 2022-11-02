using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class TblUser
    {
        public TblUser()
        {
            Tblcarts = new HashSet<Tblcart>();
            Tblorders = new HashSet<Tblorder>();
        }

        public int UserId { get; set; }
        public string FName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string ProfileImg { get; set; }
        public decimal? Mobile { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }

        public virtual Tblcity City { get; set; }
        public virtual Tblstate State { get; set; }
        public virtual ICollection<Tblcart> Tblcarts { get; set; }
        public virtual ICollection<Tblorder> Tblorders { get; set; }
    }
}
