using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AsianSnacks.Models;
using AsianSnacks.Logic;

namespace AsianSnacks.Admin
{
    public partial class AdminPage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string snackAction = Request.QueryString["SnackAction"];
      if (snackAction == "add")
      {
        LabelAddStatus.Text = "Snack added!";
      }

      if (snackAction == "remove")
      {
        LabelRemoveStatus.Text = "Snack removed!";
      }
    }

    protected void AddSnackButton_Click(object sender, EventArgs e)
    {
      Boolean fileOK = false;
      String path = Server.MapPath("~/Catalog/Images/");
      if (SnackImage.HasFile)
      {
        String fileExtension = System.IO.Path.GetExtension(SnackImage.FileName).ToLower();
        String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
        for (int i = 0; i < allowedExtensions.Length; i++)
        {
          if (fileExtension == allowedExtensions[i])
          {
            fileOK = true;
          }
        }
      }

      if (fileOK)
      {
        try
        {
          // Save to Images folder.
          SnackImage.PostedFile.SaveAs(path + SnackImage.FileName);
        }
        catch (Exception ex)
        {
          LabelAddStatus.Text = ex.Message;
        }

        // Add Snack data to DB.
        AddSnacks Snacks = new AddSnacks();
        bool addSuccess = Snacks.AddSnack(AddSnackName.Text, AddSnackDescription.Text,
            AddSnackPrice.Text, DropDownAddCategory.SelectedValue, SnackImage.FileName);
        if (addSuccess)
        {
          // Reload the page.
          string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
          Response.Redirect(pageUrl + "?SnackAction=add");
        }
        else
        {
          LabelAddStatus.Text = "Unable to add new Snack to database.";
        }
      }
      else
      {
        LabelAddStatus.Text = "Unable to accept file type.";
      }
    }

    public IQueryable GetCategories()
    {
      var _db = new AsianSnacks.Models.SnackContext();
      IQueryable query = _db.Categories;
      return query;
    }

    public IQueryable GetSnacks()
    {
      var _db = new AsianSnacks.Models.SnackContext();
      IQueryable query = _db.Snacks;
      return query;
    }

    protected void RemoveSnackButton_Click(object sender, EventArgs e)
    {
      using (var _db = new AsianSnacks.Models.SnackContext())
      {
        int SnackId = Convert.ToInt16(DropDownRemoveSnack.SelectedValue);
        var myItem = (from c in _db.Snacks where c.SnackID == SnackId select c).FirstOrDefault();
        if (myItem != null)
        {
          _db.Snacks.Remove(myItem);
          _db.SaveChanges();

          // Reload the page.
          string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
          Response.Redirect(pageUrl + "?SnackAction=remove");
        }
        else
        {
          LabelRemoveStatus.Text = "Unable to locate Snack.";
        }
      }
    }
  }
}
