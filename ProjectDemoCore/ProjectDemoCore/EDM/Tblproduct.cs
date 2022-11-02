using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class Tblproduct
    {
        public Tblproduct()
        {
            Tblcarts = new HashSet<Tblcart>();
            Tblorderdetails = new HashSet<Tblorderdetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? Cost { get; set; }
        public int? Qty { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public int? Discount { get; set; }

        public virtual ICollection<Tblcart> Tblcarts { get; set; }
        public virtual ICollection<Tblorderdetail> Tblorderdetails { get; set; }
    }
}
