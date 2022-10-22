using System;
using System.Collections.Generic;

#nullable disable

namespace EDMCrud.EDM
{
    public partial class Tblcity
    {
        public Tblcity()
        {
            Tblemployees = new HashSet<Tblemployee>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }

        public virtual Tblstate State { get; set; }
        public virtual ICollection<Tblemployee> Tblemployees { get; set; }
    }
}
