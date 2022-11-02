using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class Tblorderdetail
    {
        public int OrderdetailsId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }

        public virtual Tblorder Order { get; set; }
        public virtual Tblproduct Product { get; set; }
    }
}
