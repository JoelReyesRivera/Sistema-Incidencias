using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Incidencias
{
    public class Utileria
    {
        //static String conexion = "Data Source=LAPTOP-VEESUAN4\\JRR;Initial Catalog=SISTEMA_INCIDENCIAS;Integrated Security=True";
        // static String conexion = "Data Source=DESKTOP-CAT0FTJ\\SQLEXPRESS;Initial Catalog=SISTEMA_INCIDENCIAS;Integrated Security=True";
        //static String conexion = "Data Source=LAPTOP-42CBJ1OH\\MSSQLSERVER01;Initial Catalog=SISTEMA_INCIDENCIAS;Integrated Security=True";
        static String conexion = "Data Source=FERNANDO;Initial Catalog=SISTEMA_INCIDENCIAS;Integrated Security=True";

        public static  String GetConnectionString()
        {
            return conexion;
        }
        public static bool ValidaTextoNum(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (C < '0' || C > '9')
                    return false;
            }
            return true;
        }
        public static bool ValidaTexto(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (!(Char.IsLetter(C)) && !(Char.IsWhiteSpace(C)))
                    return false;
            }
            return true;
        }
    }
}
