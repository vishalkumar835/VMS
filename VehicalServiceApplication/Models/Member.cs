using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicalServiceApplication.Models
{
    public class Member
    {
        
        public int id { get; set; }
        [Display(Name = "User Name")]
        public string UName { get; set; }
        public string Password { get; set; }
    }
}