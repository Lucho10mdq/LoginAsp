using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUsers
{
    public partial class Bienvenido : System.Web.UI.Page
    {
        AlumnosRepository AlumnosLista;
        protected void Page_Load(object sender, EventArgs e)
        { 
            AlumnosLista = (AlumnosRepository)Session["alumnosList"];
            gridAlumnos.DataSource = AlumnosLista.DeVolverAlumnos();
            gridAlumnos.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroAlumno.aspx");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gridAlumnos.DataSource = AlumnosLista.DeVolverAlumnos();
            gridAlumnos.DataBind();
        }
    }
}