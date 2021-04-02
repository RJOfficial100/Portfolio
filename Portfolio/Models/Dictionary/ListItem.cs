using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Dictionary
{
    public class ListItem
    {
        [Key]
        public int ListItemID { get; set; }
        [Required]
        [StringLength(50)]
        public string ListItemName { get; set; }
        public int ListReferenceID { get; set; }
        [ForeignKey("ListReferenceID")]
        public ListReference ListReference { get; set; }
    }
}