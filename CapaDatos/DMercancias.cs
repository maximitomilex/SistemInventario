using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMercancias
    {
        private int _IdMercancia;
        private string _Nombre;
        private int _Precio;
        private int _Cantidad;


        public int IdMercancia
        {
            get { return _IdMercancia; }
            set { _IdMercancia = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        //Sobre carga de constructor
        public DMercancias()
        {
        
        }

        public DMercancias(int idmercancia, string nombre, int precio, int cantidad)
        {
            this.IdMercancia = idmercancia;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }

        //METHODS OF THE CLASS
        //--------------Insertar---------------------------------------------------
        public string Insertar(DMercancias mercancia)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paInsertarMercancia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idMercancia = new SqlParameter();
                idMercancia.ParameterName = "@IdMercancia";
                idMercancia.SqlDbType = SqlDbType.Int;
                idMercancia.Direction = ParameterDirection.Output;
                comando.Parameters.Add(idMercancia);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.Value = mercancia.Nombre;
                comando.Parameters.Add(nombre);

                SqlParameter precio = new SqlParameter();
                precio.ParameterName = "@Precio";
                precio.SqlDbType = SqlDbType.Int;
                precio.Value = mercancia.Precio;
                comando.Parameters.Add(precio);

                SqlParameter cantidad = new SqlParameter();
                cantidad.ParameterName = "@Cantidad";
                cantidad.SqlDbType = SqlDbType.Int;
                cantidad.Value = mercancia.Cantidad;
                comando.Parameters.Add(cantidad);

                //Ejecutamo nuestro comando 
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
        //---------------Actualizar--------------------------------------------
        public string Actualizar(DMercancias mercancia)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarMercancia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idMercancia = new SqlParameter();
                idMercancia.ParameterName = "@IdMercancia";
                idMercancia.SqlDbType = SqlDbType.Int;
                idMercancia.Value = mercancia.IdMercancia;
                comando.Parameters.Add(idMercancia);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.Value = mercancia.Nombre;
                comando.Parameters.Add(nombre);

                SqlParameter precio = new SqlParameter();
                precio.ParameterName = "@Precio";
                precio.SqlDbType = SqlDbType.Int;
                precio.Value = mercancia.Precio;
                comando.Parameters.Add(precio);

                SqlParameter cantidad = new SqlParameter();
                cantidad.ParameterName = "@Cantidad";
                cantidad.SqlDbType = SqlDbType.Int;
                cantidad.Value = mercancia.Cantidad;
                comando.Parameters.Add(cantidad);

                //Ejecutamo nuestro comando 
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
        //----------------------Eliminar--------------------------------------
        public string Eliminar(DMercancias mercancia)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarMercancia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idMercancia = new SqlParameter();
                idMercancia.ParameterName = "@IdMercancia";
                idMercancia.SqlDbType = SqlDbType.Int;
                idMercancia.Value = mercancia.IdMercancia;
                comando.Parameters.Add(idMercancia);

                //Ejecutamo nuestro comando 
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
            DataTable tabla = new DataTable("tblMercancias");

            SqlConnection con = new SqlConnection(ConexionDB.con);
            try
            {
                // SqlCommand comando = new SqlCommand("paMostrarCuentaXCobrar",con);
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarMercancia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlDataAdapter adatador = new SqlDataAdapter(comando);
                adatador.Fill(tabla);
            }
            catch
            {
                tabla = null;
            }

            return tabla;
        }


    }
}
