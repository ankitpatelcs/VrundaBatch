using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JsDemo.Models
{
    public class Employee
    {
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "First Name is Required.")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Only alphabets..!!")]
        public string fname { get; set; }

        [Display(Name = "Mobile No.")]
        [Required]
        [RegularExpression(@"\+91\-[9876]\d{9}", ErrorMessage = "Invalid Mobile No.")]
        public string mobile { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[a-zA-Z!#$%&? ])[a-zA-Z0-9!#$%&?]{8,20}$",ErrorMessage ="Password is weak.")]
        public string password { get; set; }

        
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Passwords do not match.")]
        public string cnfpassword { get; set; }
    }
}
