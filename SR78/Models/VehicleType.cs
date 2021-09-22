using System;
using System.ComponentModel.DataAnnotations;

namespace SR78.Models
{
    public class VehicleType
    {
        [Key]
        public Guid VehicleTypeId { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage ="Vehicle Type Name field is required!")]
        [Display(Name = "Vehicle Type Name")]
        public string VehicleTypeName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
