using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVenta
    {

        private int _IdVenta;
        private string _Descripcion;
        private int _Monto;

        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }

        //Sobrecarga de constructores
        public DVenta()
        { }
        public DVenta(int idventa, string descripcion, int monto)
        {
            this.IdVenta = idventa;
            this.Descripcion = descripcion;
            this.Monto = monto;
        }

        public string Insertar(DVenta venta)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paInsertarVenta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idventa = new SqlParameter();
                idventa.ParameterName = "@IdVenta";
                idventa.SqlDbType = SqlDbType.Int;
                idventa.Direction = ParameterDirection.Output;
                comando.Parameters.Add(idventa);

                SqlParameter descripcion = new SqlParameter();
                descripcion.ParameterName = "@Descripcion";
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 50;
                descripcion.Value = venta.Descripcion;
                comando.Parameters.Add(descripcion);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = venta.Monto;
                comando.Parameters.Add(monto);

                //Ejecutamos nuesto comando 
                rpt = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE INGRESO EL REGISTRO";

            }
            catch (Exception error)
            {
                rpt = error.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return rpt;
        
        }

        public string Actualizar(DVenta venta)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarVenta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idventa = new SqlParameter();
                idventa.ParameterName = "@IdVenta";
                idventa.SqlDbType = SqlDbType.Int;
                idventa.Value = venta.IdVenta;
                comando.Parameters.Add(idventa);

                SqlParameter descripcion = new SqlParameter();
                descripcion.ParameterName = "@Descripcion";
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 50;
                descripcion.Value = venta.Descripcion;
                comando.Parameters.Add(descripcion);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = venta.Monto;
                comando.Parameters.Add(monto);

                //Ejecutamos nuesto comando 
                rpt = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE ACTUALIZO EL REGISTRO";

            }
            catch (Exception error)
            {
                rpt = error.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return rpt;

        }

        public string Eliminar(DVenta venta)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarVenta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idventa = new SqlParameter();
                idventa.ParameterName = "@IdVenta";
                idventa.SqlDbType = SqlDbType.Int;
                idventa.Value = venta.IdVenta;
                comando.Parameters.Add(idventa);


                //Ejecutamos nuesto comando 
                rpt = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE ELIMINO EL REGISTRO";

            }
            catch (Exception error)
            {
                rpt = error.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return rpt;

        }

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable("tblVentas");

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarVentas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection =new SqlConnection(ConexionDB.con);

                new SqlDataAdapter(comando).Fill(tabla);
            }
            catch
            {
                tabla = null;
            
            }

            return tabla;

        }
        
    }
}
