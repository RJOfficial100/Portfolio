using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Dictionary
{
    public class ListReference
    {
        [Key]
        public int ListReferenceID { get; set; }
        [Required]
        [MaxLength(50)]
        public string ListReferenceName{ get; set; }

        public List<ListItem> ListItems { get; set; }
    }
}