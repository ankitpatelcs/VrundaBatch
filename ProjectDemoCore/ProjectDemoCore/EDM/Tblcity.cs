using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class Tblcity
    {
        public Tblcity()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }

        public virtual Tblstate State { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
