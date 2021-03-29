using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        [StringLength(10)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(10)]
        public string LastName { get; set; }
        public long PhoneNo { get; set; }
        public string DOB { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company CurrentCompany { get; set; }

    }
}