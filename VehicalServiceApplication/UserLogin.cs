using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicalServiceApplication

{



    public partial class UserLogin
    {
        
        public int Id { get; set; }
       
        [Display(Name = "User Name")]
        public string UName { get; set; }
      
        public string Password { get; set; }
    }
}
