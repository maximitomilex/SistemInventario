using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEfectivos
    {
        //Atributos de la clase

        private int _IdEfectivo;
        private string _Descripcion;
        private int _Monto;


        //Methods get, set
        public int IdEfectivo
        {
            get { return _IdEfectivo; }
            set { _IdEfectivo = value; }
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

        //Constructores, sobrecarga de constructores
        public DEfectivos()
        {
        
        }

        public DEfectivos(int idefectivo, string descripcion, int monto)
        {
            this.IdEfectivo = idefectivo;
            this.Descripcion = descripcion;
            this.Monto = monto;
        }

        //Methods of the class   ----------------------------------------
        public string Insertar(DEfectivos efectivo)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paInsertarEfectivo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdEfectivo = new SqlParameter();
                IdEfectivo.ParameterName = "@IdEfectivo";
                IdEfectivo.SqlDbType = SqlDbType.Int;
                IdEfectivo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(IdEfectivo);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = efectivo.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = efectivo.Monto;
                comando.Parameters.Add(monto);

                rpt = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE INGRESO EL REGISTO";
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
        //--------------------------------=======================
        public string Actualizar(DEfectivos efectivo)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarEfectivo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdEfectivo = new SqlParameter();
                IdEfectivo.ParameterName = "@IdEfectivo";
                IdEfectivo.SqlDbType = SqlDbType.Int;
                IdEfectivo.Value = efectivo.IdEfectivo;
                comando.Parameters.Add(IdEfectivo);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = efectivo.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = efectivo.Monto;
                comando.Parameters.Add(monto);

                rpt = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE ACTUALIZO EL REGISTO";
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
        //---------------------------------------------
        public string Eliminar(DEfectivos efectivo)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarEfectivo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXCobrar = new SqlParameter();
                IdCuentaXCobrar.ParameterName = "@IdEfectivo";
                IdCuentaXCobrar.SqlDbType = SqlDbType.Int;
                IdCuentaXCobrar.Value = efectivo.IdEfectivo;
                comando.Parameters.Add(IdCuentaXCobrar);


                rpt = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE ELIMINO EL REGISTO";
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
            DataTable tabla = new DataTable("tblEfectivos");

            SqlConnection con = new SqlConnection(ConexionDB.con);
            try
            {
               // SqlCommand comando = new SqlCommand("paMostrarCuentaXCobrar",con);
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarEfectivos";
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
