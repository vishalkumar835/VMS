using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicalServiceApplication
{
   


    public partial class ServiceCenter
    {
       
        public int ServiceCenterId { get; set; }
        [Required(ErrorMessage = "Enter Your Service center Name")]
        [Display(Name = "Service Center Name")]
        [MaxLength(20)]
        public string ServiceCenterName { get; set; }
        [Display(Name = " Booking Date")]
        [Required(ErrorMessage = "Enter Your Booking Date")]
        public string AppoinmentBookingDate { get; set; }
        [Display(Name = " Vehicle Type")]
        [Required(ErrorMessage = "Enter Your Vehicle Type")]
        public string VehicleType { get; set; }
        [Display(Name = " Vehicle Model")]
        [Required(ErrorMessage = "Enter Your Vehicle Model")]
        public string VehicleModel { get; set; }
    }
}
