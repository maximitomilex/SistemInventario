using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;     //For can acced to class of the capa data
using System.Data;

namespace CapaNegocios
{
    public class NColmado
    {
        //Method Insertar que se Comunica con la class DColmado de la CapaDatos 

        public static string Insertar(string Nombre, string Direccion, string PropietarioNombre,
            int CapitalInversion, string Telefono)
        {
            DColmado colmado = new DColmado(0, Nombre, Direccion, PropietarioNombre, CapitalInversion, Telefono, "");

            return colmado.Insertar(colmado);
             
        }

        public static string Actualizar(int IdColmado,string Nombre, string Direccion, string PropietarioNombre,
           int CapitalInversion, string Telefono)
        {
            DColmado colmado = new DColmado(IdColmado, Nombre, Direccion, PropietarioNombre, CapitalInversion, Telefono, "");

            return colmado.Actualizar(colmado);

        }

        public static string Eliminar(int IdColmado)
        {
            DColmado colmado = new DColmado();
            colmado.IdColmado = IdColmado;

            return colmado.Eliminar(colmado);
           
        }

        public static DataTable Mostrar()
        {
            return new DColmado().Mostrar();
        
        }

        public static DataTable BuscarPorNombre(string Nombre)
        {
            DColmado colmado = new DColmado();
            colmado.TextoBuscar = Nombre;

            return colmado.BuscarPorNombre(colmado);
        
        }




    }
}
