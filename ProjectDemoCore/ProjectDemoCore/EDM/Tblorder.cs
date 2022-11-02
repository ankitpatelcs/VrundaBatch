using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class Tblorder
    {
        public Tblorder()
        {
            Tblorderdetails = new HashSet<Tblorderdetail>();
        }

        public int OrderId { get; set; }
        public DateTime? Orderdate { get; set; }
        public byte? Status { get; set; }
        public int? UserId { get; set; }

        public virtual TblUser User { get; set; }
        public virtual ICollection<Tblorderdetail> Tblorderdetails { get; set; }
    }
}
