using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUsers
{
    public partial class RegistroAlumno : System.Web.UI.Page
    {
            AlumnosRepository AlumnosLista;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlumnosLista = (AlumnosRepository)Session["alumnosList"];
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string email = txtEmail.Text;
            string domicilio = txtDomicilio.Text;

            Alumno oAlu = null;
            oAlu = AlumnosLista.buscarPorDni(dni);
            if(oAlu == null)
            {
                Alumno oAlumno = new Alumno(nombre, apellido, dni, email, domicilio);
                AlumnosLista.AgregarAlumnos(oAlumno);
            }
            else
            {
                Response.Write("El Alumno ya existe");
            }
        }
    }
}