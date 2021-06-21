using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineChatWeb.AuthServiceReference;
using Microsoft.AspNet.SignalR.Client;

namespace OnlineChatWeb
{
    public partial class OnlineChat : System.Web.UI.Page
    {
        private AuthServiceClient authServiceClient = new AuthServiceClient();
        public void PrintMessage(string text)
        {
            txtMessages.Text += text + "\n";
        }
        protected void OpenWindow(object sender, EventArgs e)
        {
            popupPanel.Visible = true;
        }

        protected string GetUserNameFromServer(int cookieId)
        {        
            return authServiceClient.GetLogin(cookieId);
        }

        private int SendUserName(string username)
        {
            return authServiceClient.SaveLogin(username);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    HttpCookie cookie = Request.Cookies.Get("LoginCookie");
                    if (cookie == null)
                    {
                        popupPanel.Visible = true;
                    }
                    else
                    {
                        lblName.Text = GetUserNameFromServer(Convert.ToInt32(cookie["id"]));
                    }              
            }
        }      

      
        protected void btnOK_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Name can not be empty" + "');", true);
            }
            else
            {
                int id = SendUserName(txtName.Text);
                HttpCookie cookie = new HttpCookie("LoginCookie");
                cookie["id"] = id.ToString();
                HttpContext.Current.Response.Cookies.Add(cookie);
                popupPanel.Visible = false;
            }
            lblName.Text = txtName.Text;
        }
    }
}
