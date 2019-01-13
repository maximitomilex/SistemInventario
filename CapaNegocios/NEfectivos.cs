using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NEfectivos
    {
        //Methods--------------
        public static string Insertar(string Descripcion, int Monto)
        {
            DEfectivos efectivo = new DEfectivos(0, Descripcion, Monto);

            return efectivo.Insertar(efectivo);
        }
        //----------------
        public static string Actualizar(int IdEfectivo, string Descripcion, int Monto)
        {
            DEfectivos efectivo = new DEfectivos(IdEfectivo, Descripcion, Monto);

            return efectivo.Actualizar(efectivo);
        }
        //----------------
        public static string Eliminar(int IdEfectivo)
        {
            DEfectivos efectivo = new DEfectivos();
            efectivo.IdEfectivo = IdEfectivo;

            return efectivo.Eliminar(efectivo);
        }
        //------------------
        public static DataTable Mostrar()
        {
            return new DEfectivos().Mostrar();
        }
        
    }
}
