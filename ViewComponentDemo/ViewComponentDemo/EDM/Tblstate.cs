using System;
using System.Collections.Generic;

namespace ViewComponentDemo.EDM
{
    public partial class Tblstate
    {
        public Tblstate()
        {
            Tblcities = new HashSet<Tblcity>();
            Tblemployees = new HashSet<Tblemployee>();
        }

        public int StateId { get; set; }
        public string? StateName { get; set; }

        public virtual ICollection<Tblcity> Tblcities { get; set; }
        public virtual ICollection<Tblemployee> Tblemployees { get; set; }
    }
}
