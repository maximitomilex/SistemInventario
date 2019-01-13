using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NVenta
    {
        //Method----------------------------------------
        public static string Insertar(string Descripcion, int Monto)
        {
            DVenta venta = new DVenta(0, Descripcion, Monto);
            return venta.Insertar(venta);
        
        }

        //--------------------------------------
        public static string Actualizar(int IdVenta, string Descripcion, int Monto)
        {
            DVenta venta = new DVenta(IdVenta, Descripcion, Monto);
            return venta.Actualizar(venta);

        }

        //-----------------------------------------
        public static string Eliminar(int IdVenta)
        {
            DVenta venta = new DVenta();
            venta.IdVenta = IdVenta;
            return venta.Eliminar(venta);

        }

        public static DataTable Mostrar()
        {
            return new DVenta().Mostrar();
        }
    }
}
