using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NGasto
    {
        //Methods----------------------------
        public static string Insertar(string Descripcion, int Monto)
        {
            DGasto gasto = new DGasto(0, Descripcion, Monto);

            return gasto.Insertar(gasto);
        
        }

        //------------------------------
        public static string Actualizar(int IdGasto,string Descripcion, int Monto)
        {
            DGasto gasto = new DGasto(IdGasto, Descripcion, Monto);

            return gasto.Actualizar(gasto);

        }

        //-------------------------------
        public static string Eliminar(int IdGasto)
        {
            DGasto gasto = new DGasto();
            gasto.IdGasto = IdGasto;

            return gasto.Eliminar(gasto);

        }

        //-------------------------------------
        public static DataTable Mostrar()
        {
            return new DGasto().Mostrar();
        }
    }
}
