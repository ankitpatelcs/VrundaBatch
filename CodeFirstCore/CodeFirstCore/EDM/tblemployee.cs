using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models
{
    [Table("tblemployee")]
    public class tblemployee
    {
        [Column("emp_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int emp_id { get; set; }

        [Column("f_name")]
        [Display(Name = "First name")]
        [StringLength(20, ErrorMessage = "First name must be less than 10 characters.")]
        public string f_name { get; set; }

        [Column("salary")]
        [Display(Name = "Salary")]
        public int salary { get; set; }

        [Column("mobile")]
        [Display(Name = "Mobile No.")]
        public string mobile { get; set; }

        [Column("email")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string email { get; set; }

        [Column("dob")]
        [Display(Name = "Date Of Birth")]
        public DateTime? dob { get; set; }

        [Column("address")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Column("city_id")]
        [Display(Name = "City")]
        public int? city_id { get; set; }

    }
}
