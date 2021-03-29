using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [StringLength(30)]
        [Display(Name ="Company Name")]
        [Required]
        public string CompanyName { get; set; }
        [StringLength(50)]
        [Display(Name ="Location")]
        public string CompanyLocation { get; set; }
        [StringLength(30)]
        [Display(Name ="Job Title")]
        [Required]
        public string JobTitle { get; set; }

        public List<Project> Projects { get; set; }
    }
}