using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCuentaXCobrar
    {

        //Atributos de la clase

        private int _IdCuentaXCobrar;
        private string _Descripcion;
        private int _Monto;


        //Methods get, set
        public int IdCuentaXCobrar
        {
            get { return _IdCuentaXCobrar; }
            set { _IdCuentaXCobrar = value; }
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
        public DCuentaXCobrar()
        {
        
        }

        public DCuentaXCobrar(int idcuentaXcobrar, string descripcion, int monto)
        {
            this.IdCuentaXCobrar = idcuentaXcobrar;
            this.Descripcion = descripcion;
            this.Monto = monto;
        }

        //Methods of the class   ----------------------------------------
        public string Insertar(DCuentaXCobrar cxc)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paInsertarCuentaXCobrar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXCobrar = new SqlParameter();
                IdCuentaXCobrar.ParameterName = "@IdCuentaXCobrar";
                IdCuentaXCobrar.SqlDbType = SqlDbType.Int;
                IdCuentaXCobrar.Direction = ParameterDirection.Output;
                comando.Parameters.Add(IdCuentaXCobrar);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = cxc.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = cxc.Monto;
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
        public string Actualizar(DCuentaXCobrar cxc)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarCuentaXCobrar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXCobrar = new SqlParameter();
                IdCuentaXCobrar.ParameterName = "@IdCuentaXCobrar";
                IdCuentaXCobrar.SqlDbType = SqlDbType.Int;
                IdCuentaXCobrar.Value = cxc.IdCuentaXCobrar;
                comando.Parameters.Add(IdCuentaXCobrar);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = cxc.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = cxc.Monto;
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
        public string Eliminar(DCuentaXCobrar cxc)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarCuentaXCobrar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXCobrar = new SqlParameter();
                IdCuentaXCobrar.ParameterName = "@IdCuentaXCobrar";
                IdCuentaXCobrar.SqlDbType = SqlDbType.Int;
                IdCuentaXCobrar.Value = cxc.IdCuentaXCobrar;
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
            DataTable tabla = new DataTable("tblCuentaXCobrar");

            SqlConnection con = new SqlConnection(ConexionDB.con);
            try
            {
               // SqlCommand comando = new SqlCommand("paMostrarCuentaXCobrar",con);
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarCuentaXCobrar";
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
