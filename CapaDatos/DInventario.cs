using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Libreria usada en la class
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class DInventario
    {

        //Atributos
        private int _IdInventario;
        private int _Ventas;
        private int _Mercancia;
        private int _CuentaXCobrar;
        private int _CuentaXPagar;
        private int _Efectivo;
        private int _Gasto;
        private int _IdColmado;
        private DateTime _Fecha;
        private string _textoBuscar;

       

        //Propiedades 
        public int IdInventario
        {
            get { return _IdInventario; }
            set { _IdInventario = value; }
        }

        public int Ventas
        {
            get { return _Ventas; }
            set { _Ventas = value; }
        }

        public int Mercancia
        {
            get { return _Mercancia; }
            set { _Mercancia = value; }
        }

        public int CuentaXCobrar
        {
            get { return _CuentaXCobrar; }
            set { _CuentaXCobrar = value; }
        }

        public int CuentaXPagar
        {
            get { return _CuentaXPagar; }
            set { _CuentaXPagar = value; }
        }

        public int Efectivo
        {
            get { return _Efectivo; }
            set { _Efectivo = value; }
        }

        public int Gasto
        {
            get { return _Gasto; }
            set { _Gasto = value; }
        }

        public int IdColmado
        {
            get { return _IdColmado; }
            set { _IdColmado = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string TextoBuscar
        {
            get { return _textoBuscar; }
            set { _textoBuscar = value; }
        }

        //Sobrecarga de constructores
        public DInventario()
        {
        
        }

        public DInventario(int idinventario, int ventas, int mercancia, int cuentaXcobrar, int cuentaXpagar
            , int efectivo, int gasto, int idcolmado, DateTime fecha)
        {
            this.IdInventario = idinventario;
            this.Ventas = ventas;
            this.Mercancia = mercancia;
            this.CuentaXCobrar = cuentaXcobrar;
            this.CuentaXPagar = cuentaXpagar;
            this.Efectivo = efectivo;
            this.Gasto = gasto;
            this.IdColmado = idcolmado;
            this.Fecha = fecha;
        }

        //Methods of the class

        public string Insertar(DInventario inventario)//Para insertar registros
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paCrearInventario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idcolmado = new SqlParameter();
                idcolmado.ParameterName = "@IdColmado";
                idcolmado.SqlDbType = SqlDbType.Int;
                idcolmado.Value = inventario.IdColmado;
                comando.Parameters.Add(idcolmado);

                //Ejecutar nuestro comando de query
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


        public string Actualizar(DInventario inventario)//Para Actualizar registros
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarInventario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idInventario = new SqlParameter();
                idInventario.ParameterName = "@IdInventario";
                idInventario.SqlDbType = SqlDbType.Int;
                idInventario.Value = inventario.IdInventario;
                comando.Parameters.Add(idInventario);

                //Ejecutar nuestro comando de query
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

        public string Eliminar(DInventario inventario)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;

            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarInventario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idinventario = new SqlParameter();
                idinventario.ParameterName = "@IdInventario";
                idinventario.SqlDbType = SqlDbType.Int;
                idinventario.Value = inventario.IdInventario;
                comando.Parameters.Add(idinventario);

                //Ejecutamos nuestro comando sql transql
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
            DataTable table = new DataTable("tblInventarios");

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarInventarios";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = new SqlConnection(ConexionDB.con);

                new SqlDataAdapter(comando).Fill(table);
            }
            catch
            {
                table = null;
            }

            return table;
        
        }

        public DataTable MostrarHistory()
        {
            DataTable table = new DataTable("tblInventario");

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarHistoryInventarios";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = new SqlConnection(ConexionDB.con);

                new SqlDataAdapter(comando).Fill(table);
            }
            catch
            {
                table = null;
            }

            return table;

        }
        public int MostrarLastIdInventario()
        {
            int id = 0;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;

            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "paMostraLastIdInventario";
                comando.Connection = con;

                SqlParameter idInventario = new SqlParameter();
                idInventario.ParameterName = "@IdInventario";
                idInventario.SqlDbType = SqlDbType.Int;
                idInventario.Direction = ParameterDirection.Output;
                comando.Parameters.Add(idInventario);

                comando.ExecuteNonQuery();

               id=Convert.ToInt32( comando.Parameters["@IdInventario"].Value.ToString());

            }
            catch
            {
                id = 0;
            }
            return id;
           
        }



        public DataTable BuscarPorNombreInventario(DInventario inventario)
        {
            DataTable table = new DataTable("tblInventarios");

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paBuscarInventario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = new SqlConnection(ConexionDB.con);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@txtBuscar";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.Value = inventario.TextoBuscar;
                comando.Parameters.Add(nombre);

                new SqlDataAdapter(comando).Fill(table);
            }
            catch
            {
                table = null;
            }

            return table;
        }
        
        public DataTable BuscarPorFechaInventario(DInventario inventario)
        {
            DataTable table = new DataTable("tblInventarios");

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paBuscarInventarioFecha";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = new SqlConnection(ConexionDB.con);

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.Size = 50;
                fecha.Value = inventario.Fecha;
                comando.Parameters.Add(fecha);

                new SqlDataAdapter(comando).Fill(table);
            }
            catch
            {
                table = null;
            }

            return table;
        }


        public string VaciarTablas()
        {
            string rpt = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;


            SqlTransaction transacion;
            con.Open();
            transacion = con.BeginTransaction();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = con;
                comando.Transaction = transacion;

                comando.CommandText = "Truncate table tblMercancias";
                comando.ExecuteNonQuery();
                comando.CommandText = "truncate table tblVentas";
                comando.ExecuteNonQuery();
                comando.CommandText = "truncate table tblGastos";
                comando.ExecuteNonQuery();
                comando.CommandText = "truncate table tblEfectivos";
                comando.ExecuteNonQuery();
                comando.CommandText = "truncate table tblCuentaXPagar";
                comando.ExecuteNonQuery();
                comando.CommandText = "truncate table tblCuentaXCobrar";
                comando.ExecuteNonQuery();

                transacion.Commit();

                rpt = "OK";
            }
            catch (Exception error)
            {
                rpt = error.Message + " " + error.GetType();

                try
                {
                    transacion.Rollback();
                }
                catch (Exception ex)
                {
                    rpt = ex.Message + " " + ex.GetType();
                }

            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return rpt;
        }

    }
}
