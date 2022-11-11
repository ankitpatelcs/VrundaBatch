using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeWebApi.Models
{
    public class Employee
    {
        
        [Required(ErrorMessage = "Employee ID is Required")]
        [Display(Name = "Employee ID")]
        public int EmpId { get; set; }
                
        //[Required(ErrorMessage = "First name is Required")]
        //[StringLength(10, ErrorMessage = "First name must be less than 10 characters.")]
        public string FName { get; set; }

        [Display(Name = "Salary")]
        //[Required(ErrorMessage = "Salary is Required")]
        public int Salary { get; set; }

        [Display(Name = "Mobile No.")]
        //[Required(ErrorMessage = "Mobile No. is Required")]
        public string Mobile { get; set; }

        [Display(Name = "Email")]
        //[Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        //[Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Display(Name = "Date Of Birth")]
        //[Required(ErrorMessage = "Date Of Birth is Required")]
        public DateTime? Dob { get; set; }

        [Display(Name = "Address")]
        //[Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        [Display(Name = "State")]
        //[Required(ErrorMessage = "State is Required")]
        public int? StateId { get; set; }

        [Display(Name = "City")]
        //[Required(ErrorMessage = "City is Required")]
        public int? CityId { get; set; }

        [Display(Name = "Gender")]
        //[Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

        [Display(Name = "Hobbies")]
        //[Required(ErrorMessage = "Hobbies is Required")]
        public string Hobbies { get; set; }

        [Display(Name = "Profile Image")]
        //[Required(ErrorMessage = "Hobbies is Required")]
        public string Profileimg { get; set; }
    }
}
