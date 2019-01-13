using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NCuentaXPagar
    {
        //All this methods se comunican with the methods of the class DCuentaXPagar de la CapaDatos
        public static string Insertar(string Descripcion, int Monto)
        {
            DCuentaXPagar cuenta = new DCuentaXPagar(0, Descripcion, Monto);

            return cuenta.Insertar(cuenta);
        
        }

        public static string Actualizar(int IdCuentaXPagar, string Descripcion, int Monto)
        {
            DCuentaXPagar cuenta = new DCuentaXPagar(IdCuentaXPagar, Descripcion, Monto);

            return cuenta.Actualizar(cuenta);

        }

        public static string Eliminar(int IdCuentaXPagar)
        {
            DCuentaXPagar cuenta = new DCuentaXPagar();
            cuenta.IdCuentaXPagar = IdCuentaXPagar;

            return cuenta.Eliminar(cuenta);
        }

        public static DataTable Mostrar()
        {
            return new DCuentaXPagar().Mostrar();
        }
    }
}
