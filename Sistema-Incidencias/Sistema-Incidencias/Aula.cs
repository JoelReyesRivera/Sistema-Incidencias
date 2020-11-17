using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Incidencias
{
    class Aula
    {
        public String ID
        { get; set; }
        public String Descripcion
        { get; set; }
        public String JefeDepartamento
        { get; set; }

        public Aula(String ID, string Descripcion, String JefeDepartamento)
        {
            this.ID = ID;
            this.Descripcion = Descripcion;
            this.JefeDepartamento = JefeDepartamento;
        }
    }
}
