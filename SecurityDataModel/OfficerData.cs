using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityDataModel
{
    public class OfficerData
    {   
        [Key]
        public int OfficerId { get; set; }
        [Required]
        [Display(Name ="Full Name")]
        public string OfficerName { get; set; }= String.Empty;
        [Required]
        [Display(Name ="Gender")]
        public Gender OfficerGender { get; set; }
        [Required]
        [Display(Name ="Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        [Display(Name ="Current address")]
        public string Address { get; set; } = String.Empty;
        [Required]
        [Display(Name ="Email address")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Must be a valid email address")]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Mobile Number")]
        public string Mobile { get; set; }
        public DateTime OfficerRegistrationTime { get; set; }
        public OfficerData()
        {
            OfficerRegistrationTime = DateTime.Now;
        }
        public enum Gender
        {
            Select,
            Male,
            Female
        }
      
    }
}
