using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Technology
    {
        [Key]
        public int TechnologyId { get; set; }
        [StringLength(20)]
        public string TechnologyName { get; set; }
        public List<Project> Projects { get; set; }
    }
}