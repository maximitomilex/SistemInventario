using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
     public class NCuentaXCobrar
    {

         public static string Insertar(string Descripcion, int Monto)
         {
             DCuentaXCobrar cuenta = new DCuentaXCobrar(0, Descripcion, Monto);

             return cuenta.Insertar(cuenta);
         }

         public static string Actualizar(int IdCuentaXCobrar, string Descripcion, int Monto)
         {
             DCuentaXCobrar cuenta = new DCuentaXCobrar(IdCuentaXCobrar, Descripcion, Monto);

             return cuenta.Actualizar(cuenta);
         }

         public static string Eliminar(int IdCuentaXCobra)
         {
             DCuentaXCobrar cuenta = new DCuentaXCobrar();
             cuenta.IdCuentaXCobrar = IdCuentaXCobra;

             return cuenta.Eliminar(cuenta);
         }

         public static DataTable Mostrar()
         {

             return new DCuentaXCobrar().Mostrar();
         }


    }
}
