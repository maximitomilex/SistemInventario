using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmMercancias : Form
    {
        public frmMercancias()
        {
            InitializeComponent();
            dtgViewMercancias.DataSource = CapaNegocios.NMercancias.Mostrar();
            dtgViewMercancias.Columns["IdMercancia"].Visible = false;
            dtgViewMercancias.Columns["Total"].DefaultCellStyle.Format = "#,#";
            dtgViewMercancias.Columns["Precio"].DefaultCellStyle.Format = "#,#";
            dtgViewMercancias.Columns["Cantidad"].DefaultCellStyle.Format = "#,#";

        }
        public const string Nombre = "Mercancia";



        private void txtcantidad_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtcantidad, lblcantidad,"Cantidad");
            UtilidadesFRM.DeFocalizartxt(txtdescripcion, lblnombre, "Nombre");
            UtilidadesFRM.DeFocalizartxt(Monto, lblprecio, "$ Precio");
        }

        private void txtcantidad_Click(object sender, EventArgs e)
        {
            txtcantidad_Enter(null, e);
        }

        private void Monto_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(Monto, lblprecio,"$ Precio");
            UtilidadesFRM.DeFocalizartxt(txtcantidad, lblcantidad, "Cantidad");
            UtilidadesFRM.DeFocalizartxt(txtdescripcion, lblnombre, "Nombre");

        }

        private void Monto_Click(object sender, EventArgs e)
        {
            Monto_Enter(null, e);
        }

        private void txtdescripcion_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtdescripcion,lblnombre,"Nombre");
            UtilidadesFRM.DeFocalizartxt(Monto, lblprecio, "$ Precio");
            UtilidadesFRM.DeFocalizartxt(txtcantidad, lblcantidad, "Cantidad");
        }

        private void txtdescripcion_Click(object sender, EventArgs e)
        {
            txtdescripcion_Enter(null, e);
        }

        private void txtcantidad_TabStopChanged(object sender, EventArgs e)///Clear
        {
            UtilidadesFRM.DeFocalizartxt(txtcantidad, lblcantidad, "Cantidad");
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnguardar_Click(null, e);
            }
            UtilidadesFRM.soloNumeroEnteros(e);
        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnguardar_Click(null, e);
            }
            //e.Handled =!char.IsDigit(e.KeyChar) &&  e.KeyChar !=(char)8;
            //if (e.KeyChar == (char)13)
            //{
            //    Monto.Text = string.Format("{0:n0}", double.Parse(Monto.Text));
            //}
            UtilidadesFRM.soloNumeroEnteros(e);
          
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnguardar_Click(null, e);
            }
        }

       //Methods
        private bool Inserta(TextBox Cant, TextBox Nomb, TextBox Precio)
        {
            bool rpt = false;

            if (UtilidadesFRM.validadtxt(Cant,"Cantidad") && UtilidadesFRM.validadtxt(Nomb, "Nombre") && UtilidadesFRM.validadtxt(Precio, "$ Precio"))
            {
                rpt = true;
            }

            return rpt;
        }
        //
        private void LimpiarTxtEnter()
        {
            txtcantidad.Clear();
            txtdescripcion.Clear();
            Monto.Clear();
            txtcantidad_Click(null, null);
            txtcantidad.Focus();
        }

    

        private void btnguardar_Click(object sender, EventArgs e)
        {

            //Limite de digitos en en la columna calculada 6==6

            if (Inserta(txtcantidad, txtdescripcion, Monto))
            {
                int cantidad = Convert.ToInt32(txtcantidad.Text);
                int precio = Convert.ToInt32(Monto.Text);

                if (UtilidadesFRM.LimiteCalculoPermitido(cantidad, precio))
                {
                    string rpt = CapaNegocios.NMercancias.Insertar(txtdescripcion.Text, precio, cantidad);

                    if (rpt.Equals("OK"))
                    {
                        dtgViewMercancias.DataSource = CapaNegocios.NMercancias.Mostrar();
                        LimpiarTxtEnter();
                    }
                }
                else
                    UtilidadesFRM.UsuarioMensajeInformation("Estos valores  son Demasiado grande");
            }

        }

        private void dtgViewMercancias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          AbrirDML();
        }

        public void actualizardgview(int i)
        {
            dtgViewMercancias.DataSource = CapaNegocios.NMercancias.Mostrar();
        }

        private void AbrirDML()
        {
            try
            {
                frmDMLentidades DML = new frmDMLentidades();
                DML.Tabla = Nombre;
                DML.Id = Convert.ToInt32(dtgViewMercancias.CurrentRow.Cells["IdMercancia"].Value);
                DML.Cantidad = Convert.ToInt32(dtgViewMercancias.CurrentRow.Cells["Cantidad"].Value);
                DML.Descripcion = dtgViewMercancias.CurrentRow.Cells["Nombre"].Value.ToString();
                DML.Precio = Convert.ToInt32(dtgViewMercancias.CurrentRow.Cells["Precio"].Value);
                DML.Actualizaciondgview += new frmDMLentidades.Actualizardgview(actualizardgview);
                DML.ShowDialog();
            }
            catch
            { 
              ///Mensaje optionar
            }
        }
        private void Monto_TextChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}
