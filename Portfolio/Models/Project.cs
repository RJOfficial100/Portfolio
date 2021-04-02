using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [StringLength(30)]
        [Required]
        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Company")]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [StringLength(30)]
        public string Role { get; set; }

        [StringLength(1000)]
        [Display(Name = "Project Description")]
        public string ProjectDescription { get; set; }


        [StringLength(10)]
        [Display(Name = "Start Month")]
        public string StartMonth { get; set; }

        [Display(Name = "Start Year")]
        public string StartYear { get; set; }

        [Display(Name = "End Month")]
        [StringLength(10)]
        public string EndMonth { get; set; }
        
        [Display(Name = "End Year")]
        public string EndYear { get; set; }

        public bool Current { get; set; }

        [Display(Name = "Technologies Used")]
        public string TechnologiesUsed { get; set; }



    }
}