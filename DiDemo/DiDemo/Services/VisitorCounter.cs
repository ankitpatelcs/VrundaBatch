using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo.Services
{
    public class VisitorCounter : IVisitorCounter
    {
        public int Count { get; set; }
        public int GetCount()
        {
            Count++;
            return Count;
        }
    }
}
