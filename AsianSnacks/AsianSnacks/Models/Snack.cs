using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AsianSnacks.Models
{
    public class Snack
    {
        [ScaffoldColumn(false)]
        public int SnackID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string SnackName { get; set; }

        [Required, StringLength(10000), Display(Name = "Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}