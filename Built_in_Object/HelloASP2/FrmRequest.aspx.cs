using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP2
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = String.Empty;
            string strName = "";
            string strAge = String.Empty;

            // [1] Request 객체의 QueryString 컬렉션
            strUserId = Request["UserID"];
            // [2] Request 객체의 Params 컬렉션
            strPassword = Request.Params["Password"];
            // [3] Request 객체의 Form 컬렉션
            strName = Request.Form["Name"];
            // [4] Request 객체 자체로 받기
            strAge = Request["Age"];
            string strMsg = String.Format(
                "<div>입력하신 아이디는 {0}이고<br />" +
                "암호는 {1}입니다.<br />" +
                "이름은 {2}이고<br />" +
                "나이는 {3}살 입니다.<br /><div/>", strUserId, strPassword, strName, strAge);
            Response.Write(strMsg);
            // 왜 크롬에서는 이상하게 보이고, 익플에서는 잘 보일까...?
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // ASP.NET에서는 Request 개체보다는
            // 컨트롤의 속성을 사용해서 값을 받는다
            string name = Name.Text;
            int age = Convert.ToInt16(Age.Text);
        }
    }
}