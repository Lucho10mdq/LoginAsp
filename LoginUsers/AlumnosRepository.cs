using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginUsers
{
    public class AlumnosRepository
    {
        private List<Alumno> ListaAlumnos = new List<Alumno>();

        public void AgregarAlumnos(Alumno oAlumno)
        {
            int count = 0;
            count = ListaAlumnos.Count;
            oAlumno.Id = count + 1;
            ListaAlumnos.Add(oAlumno);
        }
        public Alumno buscarPorDni(string dni)
        {
            Alumno oAlu = null;
            foreach(Alumno a in ListaAlumnos)
            {
                if(dni == a.Dni)
                {
                    oAlu = a;
                    return oAlu;
                }         
            }
            return oAlu;
        }
        public List<Alumno> DeVolverAlumnos()
        {
            return ListaAlumnos;
        }
    }
}