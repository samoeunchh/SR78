using System;
using System.ComponentModel.DataAnnotations;

namespace SR78.Models
{
    public class Brand
    {
        [Key]
        public Guid BrandId { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name ="Brand Name")]
        public string BrandName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
