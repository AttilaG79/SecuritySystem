using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityDataModel
{
    public class StoresData
    {
        [Key]
        public int StoreId { get; set; }
        [Required]
        [Display(Name = "Store Name")]
        public string StoreName { get; set; } = String.Empty;
        [Required]
        [Display(Name = "Store Address")]
        public string StoreAddress { get; set; } = String.Empty;
        [Required]
        [Display(Name = "Postcode")]
        public string PostCode { get; set; } = String.Empty;
        [Required]
        [Display(Name ="Phone number")]
        public int StorePhone { get; set; }
        public DateTime StoreRegistrationTime { get; set; }

    }
}
