using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sequencecount
    {
    public partial class tphresult : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
            {
            Sequence FindPat = new Sequence();

            //find contiguous string pattern and assign to literal control
            Tphlit101.Text =  FindPat.FindPathSeq(FindPat.GetSubPaths());              
            }
        }
    }