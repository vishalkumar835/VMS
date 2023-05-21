using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicalServiceApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTable
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter Your Name")]
        [Display(Name = "User Name")]
        [MaxLength(20)]
        public string UserName { get; set; }
      
        [Display(Name = "User Phone")]
        [Required(ErrorMessage = "Enter Your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string UserPhone { get; set; }
        
        [Display(Name = "User Address")]
        [Required(ErrorMessage = "Enter Your Address")]
        public string UserAddress { get; set; }
        
        [Display(Name = "Service Id")]
        [Required(ErrorMessage = "Enter Your service Id")]
        public int ServiceCenterId { get; set; }
    }
}
