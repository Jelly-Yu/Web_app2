using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AsianSnacks.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string Username { get; set; }

        public int SnackId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrice { get; set; }

    }
}