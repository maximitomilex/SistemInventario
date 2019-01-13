using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DGasto
    {
        //Atributos de la clase

        private int _IdGasto;
        private string _Descripcion;
        private int _Monto;


        //Methods get, set
        public int IdGasto
        {
            get { return _IdGasto; }
            set { _IdGasto = value; }
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
        public DGasto()
        {
        
        }

        public DGasto(int idgasto, string descripcion, int monto)
        {
            this.IdGasto= idgasto;
            this.Descripcion = descripcion;
            this.Monto = monto;
        }

        //Methods of the class   ----------------------------------------
        public string Insertar(DGasto gasto)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paInsertarGasto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdEGasto = new SqlParameter();
                IdEGasto.ParameterName = "@IdGasto";
                IdEGasto.SqlDbType = SqlDbType.Int;
                IdEGasto.Direction = ParameterDirection.Output;
                comando.Parameters.Add(IdEGasto);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = gasto.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = gasto.Monto;
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
        public string Actualizar(DGasto gasto)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarGasto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdEfectivo = new SqlParameter();
                IdEfectivo.ParameterName = "@IdGasto";
                IdEfectivo.SqlDbType = SqlDbType.Int;
                IdEfectivo.Value = gasto.IdGasto;
                comando.Parameters.Add(IdEfectivo);

                SqlParameter Descripcio = new SqlParameter();
                Descripcio.ParameterName = "@Descripcion";
                Descripcio.SqlDbType = SqlDbType.VarChar;
                Descripcio.Size = 50;
                Descripcio.Value = gasto.Descripcion;
                comando.Parameters.Add(Descripcio);

                SqlParameter monto = new SqlParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Int;
                monto.Value = gasto.Monto;
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
        public string Eliminar(DGasto gasto)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarGasto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter IdCuentaXCobrar = new SqlParameter();
                IdCuentaXCobrar.ParameterName = "@IdGasto";
                IdCuentaXCobrar.SqlDbType = SqlDbType.Int;
                IdCuentaXCobrar.Value = gasto.IdGasto;
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
            DataTable tabla = new DataTable("tblGastos");

            SqlConnection con = new SqlConnection(ConexionDB.con);
            try
            {
               // SqlCommand comando = new SqlCommand("paMostrarCuentaXCobrar",con);
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarGasto";
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
