using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUsers
{
    public partial class Login : System.Web.UI.Page
    {
        UserRepository UserList;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserList = (UserRepository)Session["userList"];
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;
          
            User oUser = null;

            oUser = UserList.GetUserByEmail(email, password);
            if (oUser != null)
                Response.Redirect("Bienvenido.aspx");
            else
                lblError.Text = "El usuario no Existe";
        }
    }
}