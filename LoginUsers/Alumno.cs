using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginUsers
{
    public class Alumno
    {
        string nombre, apellido, dni, email, domicilio;
        int id;

        public Alumno(string nombre, string apellido, string dni, string email, string domicilio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.email = email;
            this.domicilio = domicilio;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }

            set
            {
                domicilio = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}