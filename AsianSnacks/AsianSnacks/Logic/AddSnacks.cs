using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsianSnacks.Models;

namespace AsianSnacks.Logic
{
    public class AddSnacks
    {
        public bool AddSnack(string SnackName, string SnackDesc, string SnackPrice, string SnackCategory, string SnackImagePath)
    {
      var mySnack = new Snack();
      mySnack.SnackName = SnackName;
      mySnack.Description = SnackDesc;
      mySnack.UnitPrice = Convert.ToDouble(SnackPrice);
      mySnack.ImagePath = SnackImagePath;
      mySnack.CategoryID = Convert.ToInt32(SnackCategory);

      using (SnackContext _db = new SnackContext())
      {
        // Add Snack to DB.
        _db.Snacks.Add(mySnack);
        _db.SaveChanges();
      }
      // Success.
      return true;
    }
  }
}