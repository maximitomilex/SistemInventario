using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NMercancias
    {
        //Methods-------------------------------------------
        public static string Insertar(string Nombre, int Precio, int Cantidad)
        {
            DMercancias mercancia = new DMercancias(0, Nombre, Precio, Cantidad);
            return mercancia.Insertar(mercancia);
        
        }

        //----------------------------------
        public static string Actualizar(int IdMercancia, string Nombre, int Precio, int Cantidad)
        {
            DMercancias mercancia = new DMercancias(IdMercancia, Nombre, Precio, Cantidad);
            return mercancia.Actualizar(mercancia);
        }

        //-----------------------------------
        public static string Eliminar(int IdMercancia)
        {
            DMercancias mercancia = new DMercancias();
            mercancia.IdMercancia = IdMercancia;
            return mercancia.Eliminar(mercancia);

        }

        public static DataTable Mostrar()
        {
            return new DMercancias().Mostrar();
        }
    }
}
