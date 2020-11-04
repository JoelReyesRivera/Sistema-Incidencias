using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Incidencias
{
    public class Jefe
    {
        public String Usuario
        { get; set; }
        public String Password
        { get; set; }
        public String Departamento
        { get; set; }

        public Jefe(String usuario, string password, String departamento)
        {
            Usuario = usuario;
            Password = password;
            Departamento = departamento;
        }
    }
}
