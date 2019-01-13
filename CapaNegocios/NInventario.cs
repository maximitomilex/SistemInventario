using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
     public class NInventario
    {

        //Methods---------------------------------
        public static string Insertar(int IdColmado)
        {
            DInventario inventario = new DInventario();
            inventario.IdColmado = IdColmado;
            return inventario.Insertar(inventario);
        }

        //--------------------------------------------
        public static string Actualizar(int IdInventario)
        {
            DInventario inventario = new DInventario();
            inventario.IdInventario = IdInventario;
            return inventario.Actualizar(inventario);
        }

        //---------------------------------------
        public static string Eliminar(int IdInventario)
        {
            DInventario inventario = new DInventario();
            inventario.IdInventario = IdInventario;
            return inventario.Eliminar(inventario);
        }

        //Method of query fo database 
        public static DataTable Mostrar()
        {
            //A este tipo de llamado a un objeto se le llama clase anonima
            return new DInventario().Mostrar();
        }
        //
        public static DataTable MostrarHistory()
        {
            return new DInventario().MostrarHistory();
        }
        public static int MostrarLastIdInventario()
        {
            return new DInventario().MostrarLastIdInventario();
        }
        public static DataTable BuscarPorNombreInventario(string Nombre)
        {
            DInventario inventario = new DInventario();
            inventario.TextoBuscar = Nombre;
            return inventario.BuscarPorNombreInventario(inventario);
        }
        //
        public static DataTable BuscarPorFechaInventario(DateTime Fecha)
        {
            DInventario inventario = new DInventario();
            inventario.Fecha = Fecha;
            return inventario.BuscarPorFechaInventario(inventario);
        }

        public static string VaciarTablas()
        {
            return new DInventario().VaciarTablas();
        }
    }
}
