using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models
{
    public class tblcity
    {
        [Key]
        public int city_id { get; set; }
        public string city_name { get; set; }
    }
}
