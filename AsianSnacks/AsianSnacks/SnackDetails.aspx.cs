using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AsianSnacks.Models;
using System.Web.ModelBinding;

namespace AsianSnacks
{
    public partial class SnackDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Snack> GetSnack([QueryString("snackID")] int? snackId)
        {
            var _db = new AsianSnacks.Models.SnackContext();
            IQueryable<Snack> query = _db.Snacks;
            if(snackId.HasValue && snackId > 0)
            {
                query = query.Where(p => p.SnackID == snackId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}