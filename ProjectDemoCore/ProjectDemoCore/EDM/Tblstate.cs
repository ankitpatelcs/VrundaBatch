using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class Tblstate
    {
        public Tblstate()
        {
            TblUsers = new HashSet<TblUser>();
            Tblcities = new HashSet<Tblcity>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
        public virtual ICollection<Tblcity> Tblcities { get; set; }
    }
}
