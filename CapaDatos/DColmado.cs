using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DColmado
    {
        //Atributos 
        private int _IdColmado;
        private string _Nombre;
        private string _Direccion;
        private string _NombrePropietario;
        private int _CapitalInversion;
        private string _Telefono;
        private string _textoBuscar;

      


        //Propiedades de la clase
        public int IdColmado
        {
            get { return _IdColmado; }
            set { _IdColmado = value; }
        }
        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string NombrePropietario
        {
            get { return _NombrePropietario; }
            set { _NombrePropietario = value; }
        }

        public int CapitalInversion
        {
            get { return _CapitalInversion; }
            set { _CapitalInversion = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string TextoBuscar
        {
            get { return _textoBuscar; }
            set { _textoBuscar = value; }
        }

        //Constructores de la clase (Sobre carga de Constructores)

        public DColmado()//Constructor Vacio
        {
        
        }

        public DColmado(int idcolmado, string nombre, string direccion, string nombrepropietario,
            int capitalInvercion, string telefono, string textobuscar)
        {
            this.IdColmado = idcolmado;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.NombrePropietario = nombrepropietario;
            this.CapitalInversion = capitalInvercion;
            this.Telefono = telefono;
            this.TextoBuscar = textobuscar;
        }

        //Methods of the class

        public string Insertar(DColmado colmado)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;

            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paInsertarColmado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idColmado = new SqlParameter();
                idColmado.ParameterName = "@IdColmado";
                idColmado.Direction = ParameterDirection.Output;
                idColmado.SqlDbType = SqlDbType.Int;
                comando.Parameters.Add(idColmado);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.Value = colmado.Nombre;
                comando.Parameters.Add(nombre);

                SqlParameter direccion = new SqlParameter();
                direccion.ParameterName = "@Direccion";
                direccion.SqlDbType = SqlDbType.VarChar;
                direccion.Size = 50;
                direccion.Value = colmado.Direccion;
                comando.Parameters.Add(direccion);

                SqlParameter nombrepropietario = new SqlParameter();
                nombrepropietario.ParameterName = "@NombrePropietario";
                nombrepropietario.SqlDbType = SqlDbType.VarChar;
                nombrepropietario.Size = 50;
                nombrepropietario.Value = colmado.NombrePropietario;
                comando.Parameters.Add(nombrepropietario);

                SqlParameter capitalInversion = new SqlParameter();
                capitalInversion.ParameterName = "@CapitalInversion";
                capitalInversion.SqlDbType = SqlDbType.Int;
                capitalInversion.Value = colmado.CapitalInversion;
                comando.Parameters.Add(capitalInversion);

                SqlParameter telefono = new SqlParameter();
                telefono.ParameterName = "@Telefono";
                telefono.SqlDbType = SqlDbType.VarChar;
                telefono.Size = 13;
                telefono.Value = colmado.Telefono;
                comando.Parameters.Add(telefono);

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


        public string Actualizar(DColmado colmado)
        {
            string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;

            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paActualizarColmado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idColmado = new SqlParameter();
                idColmado.ParameterName = "@IdColmado";
                idColmado.SqlDbType = SqlDbType.Int;
                idColmado.Value = colmado.IdColmado;
                comando.Parameters.Add(idColmado);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.Value = colmado.Nombre;
                comando.Parameters.Add(nombre);

                SqlParameter direccion = new SqlParameter();
                direccion.ParameterName = "@Direccion";
                direccion.SqlDbType = SqlDbType.VarChar;
                direccion.Size = 50;
                direccion.Value = colmado.Direccion;
                comando.Parameters.Add(direccion);

                SqlParameter nombrepropietario = new SqlParameter();
                nombrepropietario.ParameterName = "@NombrePropietario";
                nombrepropietario.SqlDbType = SqlDbType.VarChar;
                nombrepropietario.Size = 50;
                nombrepropietario.Value = colmado.NombrePropietario;
                comando.Parameters.Add(nombrepropietario);

                SqlParameter capitalInversion = new SqlParameter();
                capitalInversion.ParameterName = "@CapitalInversion";
                capitalInversion.SqlDbType = SqlDbType.Int;
                capitalInversion.Value = colmado.CapitalInversion;
                comando.Parameters.Add(capitalInversion);

                SqlParameter telefono = new SqlParameter();
                telefono.ParameterName = "@Telefono";
                telefono.SqlDbType = SqlDbType.VarChar;
                telefono.Size = 13;
                telefono.Value = colmado.Telefono;
                comando.Parameters.Add(telefono);

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

        public string Eliminar(DColmado colmado)
        { 
            
         string rpt = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;

            try
            {
                con.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paEliminarColmado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter idColmado = new SqlParameter();
                idColmado.ParameterName = "@IdColmado";
                idColmado.SqlDbType = SqlDbType.Int;
                idColmado.Value = colmado.IdColmado;
                comando.Parameters.Add(idColmado);

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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConexionDB.con;
            DataTable tabla = new DataTable("tblColmados");

            try
            {
               // SqlCommand comando = new SqlCommand("paMostrarColmados",con);

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paMostrarColmados";
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

        public DataTable BuscarPorNombre(DColmado colmado)
        {
            SqlConnection con = new SqlConnection();
            DataTable tabla = new DataTable("tblColmados");

            try
            {

                con.ConnectionString = ConexionDB.con;
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "paBuscarColmadoporNombre";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = con;

                SqlParameter textobuscar = new SqlParameter();
                textobuscar.ParameterName = "@Nombre";
                textobuscar.SqlDbType = SqlDbType.VarChar;
                textobuscar.Size = 50;
                textobuscar.Value = colmado.TextoBuscar;
                comando.Parameters.Add(textobuscar);

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
