using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class Tblcart
    {
        public int CartId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }
        public int? UserId { get; set; }

        public virtual Tblproduct Product { get; set; }
        public virtual TblUser User { get; set; }
    }
}
