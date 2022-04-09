using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityDataModel
{
    public class SecurityData
    {   
       [Key]
        public int Id { get; set; }
           
       
        [Display(Name ="Suspect Name")]
        public string? SuspectName { get; set; }
        [Required, Display(Name ="IC Codes/Identity Code")]
        public IcCodes IcCode { get; set; }
        [Required]
        [Display(Name="Gender")]
       
        public Gender Sex { get; set; }
        //suspect image ?
        [DataType(DataType.Date)] 
        [Display(Name ="Suspect Date of Birth")]
        public DateTime? DOB { get; set; }
        public string Address { get; set; } = string.Empty;
        [Display(Name ="Registration Date and Time")]
        public DateTime RegDateTime { get; set; }
        
        [Display(Name ="Incident Details")]
        public string? IncidentDetails { get; set; }
        [Display(Name ="Police Officer name")]
        public string? PoliceName { get; set; }
        [Display(Name ="Police officer badge number")]

        public int PoilceBadgeNumber { get; set; }

        //StoreData connection
        public int Store_Id { get; set; }
       
        public StoresData? GetStores { get; set; }
        //OfficerData connection
        public int Officer_Id { get; set; }
        
        public OfficerData? GetOfficers { get; set; }
        public SecurityData()
        {
            RegDateTime = DateTime.Now;
        }
        public enum Gender
        {   
            Select,
            Male,
            Female
        }
        public enum IcCodes
        {
            Select,IC1,IC2,IC3,IC4,IC5,IC6,IC7
        }
      
    }
}
