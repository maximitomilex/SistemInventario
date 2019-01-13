using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class DCuentaXPagar
    {
        //Atributos de la class
        private int _IdCuentaXPagar;
        private string _Descripcion;
        private int _Monto;


        //Methods setter and getter
        public int IdCuentaXPagar
        {
            get { return _IdCuentaXPagar; }
            set { _IdCuentaXPagar = value; }
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

        //Constructores Sobrecarga
        public DCuentaXPagar()
        {
        
        }

        public DCuentaXPagar(int idcuentaxpagar, string descripcion, int monto)
        {
            this.IdCuentaXPagar = idcuentaxpagar;
            this.Descripcion = descripcion;
            this.Monto = monto;
        
        }
        //Methods of the class connection sql servel
        public string Insertar(DCuentaXPagar cxp)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paInsertarCuentaXPagar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXPagar = new SqlParameter();
                IdCuentaXPagar.ParameterName = "@IdCuentaXPagar";
                IdCuentaXPagar.SqlDbType = SqlDbType.Int;
                IdCuentaXPagar.Direction = ParameterDirection.Output;
                comando.Parameters.Add(IdCuentaXPagar);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = cxp.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = cxp.Monto;
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
        public string Actualizar(DCuentaXPagar cxp)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarCuentaXPagar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXPagar = new SqlParameter();
                IdCuentaXPagar.ParameterName = "@IdCuentaXPagar";
                IdCuentaXPagar.SqlDbType = SqlDbType.Int;
                IdCuentaXPagar.Value = cxp.IdCuentaXPagar;
                comando.Parameters.Add(IdCuentaXPagar);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = cxp.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = cxp.Monto;
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
        public string Eliminar(DCuentaXPagar cxp)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarCuentaXPagar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXPagar = new SqlParameter();
                IdCuentaXPagar.ParameterName = "@IdCuentaXPagar";
                IdCuentaXPagar.SqlDbType = SqlDbType.Int;
                IdCuentaXPagar.Value = cxp.IdCuentaXPagar;
                comando.Parameters.Add(IdCuentaXPagar);


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
            DataTable tabla = new DataTable("tblCuentaXPagar");

            SqlConnection con = new SqlConnection(ConexionDB.con);
            try
            {
                // SqlCommand comando = new SqlCommand("paMostrarCuentaXCobrar",con);
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarCuentaXPagar";
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
