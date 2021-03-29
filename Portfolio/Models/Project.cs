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
        public string ProjectName { get; set; }
        [StringLength(10)]
        public string StartMonth { get; set; }
        [StringLength(10)]
        public string EndMonth { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public bool Current { get; set; }
        [StringLength(1000)]
        public string ProjectDescription { get; set; }
        public List<Technology> TechnologiesUsed { get; set; }
        [StringLength(30)]
        public string Role { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}