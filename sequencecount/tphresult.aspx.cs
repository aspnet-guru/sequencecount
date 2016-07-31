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
            sequence findPat = new sequence();

            //find contiguous string pattern and assign to literal control
            tphlit101.Text =  findPat.findPathSeq(findPat.getSubPaths());              
            }
        }
    }