using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUsers
{
    public partial class Registrarse : System.Web.UI.Page
    {

        UserRepository UserList;


        protected void Page_Load(object sender, EventArgs e)
        {
            UserList = (UserRepository)Session["userList"];
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            User oUser = null;
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            oUser = UserList.GetUserByEmail(email, pass);
            if (oUser == null)
            {
                User user = new User(nombre, email, pass);
                UserList.UserAdd(user);
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("el Usuario ya existe");
            }
        }
    }
}