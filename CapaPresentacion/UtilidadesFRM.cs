using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace CapaPresentacion
{
    class UtilidadesFRM
    {

        private static ErrorProvider error = new ErrorProvider();//Error provider


        public static void soloNumeroEnteros(KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }


        public static void llenarDataGridView(DataGridView dtgview, DataTable dt)
        {
            dtgview.DataSource = dt;
        }

        public static void Focalizartxt(TextBox textBox, Label lbl, String texto)
        {
            if (textBox.Text.Trim().Equals(texto))
            {
                textBox.Text = String.Empty;
                lbl.Visible = true;
                textBox.ForeColor = Color.Black;
            }
            else if(!textBox.Text.Trim().Equals(lbl.Text))//Modificado 17/6/18
            {
                textBox.ForeColor = Color.Black;
            }
            else
                lbl.Visible = true;
        }

        public static void DeFocalizartxt(TextBox textBox, Label lbl, String texto)
        {

            if (textBox.Text.Trim() == "")
            {
                textBox.ForeColor = SystemColors.WindowFrame;// Color.FromArgb(158, 158, 158);
                textBox.Text = texto;
                lbl.Visible = false;
            }
            else
                if (!textBox.Text.Trim().Equals(lbl.Text))
                {
                    textBox.ForeColor = Color.Black;
                    lbl.Visible = true;
                }
          
        }


        public static bool validadtxt(TextBox textbox, string texto)
        {
            bool rpt = true;
            
            if (textbox.Text.Trim().Equals(texto) || textbox.Text.Trim().Equals( ""))
            {
                //ErrorProvider error = new ErrorProvider();
                //error.SetError(textbox, "Erroor");
                rpt = false;
            }

            return rpt;

        }

        public static bool validadtxt(TextBox textbox, string texto, string ErrorMensaje)
        {
            bool rpt = true;
          
            if (textbox.Text.Trim().Equals(texto) || textbox.Text.Trim().Equals(""))
            {
               
                rpt = false;
            }
            if (!rpt)
            {
                error.SetError(textbox, ErrorMensaje);

            }
            else 
                error.Clear();

            return rpt;

        }

        public static bool LimiteCalculoPermitido(int n1, int n2)
        {
            bool rpt = false;
            long cant = (long)n1 * n2;
            String cant2 = Convert.ToString(cant);
            if (cant2.Length <= 9)
            {
                rpt = true;
            }
            return rpt;
        }

        public static string ReturnValorTXT(TextBox txt, string placeholder)
        {
            if (txt.Text.Trim().Equals(placeholder) || txt.Text.Trim() == "")
            {
                return "";
            }
            else
                return txt.Text;

        }

        public static void UsuarioMensajeInformation(String Mensaje)
        {
            MessageBox.Show(Mensaje,"Inventory System",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private static string RemoverFormato(string texto)
        {
            string textrenplasado = "";
    
            textrenplasado = texto.Replace(",", "");

            return textrenplasado;
        }

        public static string PonerFormato(string Texto)
        {
            
            string texto = RemoverFormato(Texto);

            if (Texto.Length == 4)
            {
                texto = texto.Insert(1, ",");
            }

            if (Texto.Length == 5)
            {
                texto = texto.Insert(2, ",");
            }

            if (Texto.Length == 6)
            {
                texto = texto.Insert(3, ",");
            }

            if (Texto.Length == 7)
            {
                texto = texto.Insert(1, ",");
                texto = texto.Insert(5, ",");
            }

            if (Texto.Length == 8)
            {
                texto = texto.Insert(2, ",");
                texto = texto.Insert(6, ",");
            }

           return texto;
          
        }


        //Sobrecarga de methods
       /* public static void CargarDML(string tabla, int id, int cant, string descripcion, int precio)
        {    
            frmDMLentidades DML = new frmDMLentidades();
            DML.Tabla = tabla;
            DML.Id = id;
            DML.Cantidad = cant;
            DML.Descripcion = descripcion;
            DML.Precio = precio;
            DML.ShowDialog();
        }
        public static void CargarDML(string tabla ,int id, string descripcion, int precio)
        {
            frmDMLentidades DML = new frmDMLentidades();
            DML.Tabla = tabla;
            DML.Id = id;
            DML.Descripcion = descripcion;
            DML.Precio = precio;
            DML.ShowDialog();
        }*/

    }
}
