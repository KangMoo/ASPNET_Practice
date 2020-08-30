using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP2
{
    public partial class FrmResponseWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello <br/>");
        }
        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write(
                "<span style='color:blue;'> Hello. </span><br />");
        }
        protected void btnJavaScript_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script language='JavaScript'>
            window.alert('안녕');
            </script>
            ";
            Response.Write(strJs);
        }
    }
}