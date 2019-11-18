using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerASP.NET
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iniciarButton_Click(object sender, EventArgs e)
        {
            string usuario = "isai@gmail.com";
            string password = "1234";

            if(userBox.Text == usuario && passwordBox.Text == password)
            {
                Response.Redirect("Contacto.aspx");
            }
        }

        protected void registrarButton_Click(object sender, EventArgs e)
        {

        }
    }
}