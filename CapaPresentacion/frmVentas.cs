using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();

            dgViewVentas.DataSource=NVenta.Mostrar();
            dgViewVentas.Columns["IdVenta"].Visible = false;
            dgViewVentas.Columns["Monto"].DefaultCellStyle.Format = "#,#";
        }

        public const string Nombre = "Venta";

        private void txtdescripcion_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtdescripcion, lbldescripcion, "Descripción");
            UtilidadesFRM.DeFocalizartxt(Monto, lblmonto, "$ Monto");
        }

        private void txtdescripcion_Click(object sender, EventArgs e)
        {
            txtdescripcion_Enter(null, e);
        }

        private void txtdescripcion_TabStopChanged(object sender, EventArgs e)
        {
            UtilidadesFRM.DeFocalizartxt(txtdescripcion, lbldescripcion, "Descripción");
        }

        private void Monto_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(Monto, lblmonto, "$ Monto");
            UtilidadesFRM.DeFocalizartxt(txtdescripcion, lbldescripcion, "Descripción");
        }

        private void Monto_Click(object sender, EventArgs e)
        {
            Monto_Enter(null, e);
        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesFRM.soloNumeroEnteros(e);
        }

        //Methods of the class
        private bool Insertar(TextBox txtdescripcion, TextBox monto)
        {
            bool rpt = false;

            if (UtilidadesFRM.validadtxt(txtdescripcion, "Descripción") && UtilidadesFRM.validadtxt(monto, "$ Monto"))
            {
                rpt = true;
            }

            return rpt;
        }

        private void AbrirDML()
        {
            try
            {
                frmDMLentidades DML = new frmDMLentidades();
                DML.Tabla = Nombre;
                DML.Id = Convert.ToInt32(dgViewVentas.CurrentRow.Cells["IdVenta"].Value);
                // DML.Cantidad = Convert.ToInt32(dtgViewMercancias.CurrentRow.Cells["Cantidad"].Value);
                DML.Descripcion = dgViewVentas.CurrentRow.Cells["Descripcion"].Value.ToString();
                DML.Precio = Convert.ToInt32(dgViewVentas.CurrentRow.Cells["Monto"].Value);
                DML.Actualizaciondgview += new frmDMLentidades.Actualizardgview(actualizardgview);
                DML.ShowDialog();
            }
            catch 
            {
                ///
            }
        }

        private void actualizardgview(int i)
        {
            dgViewVentas.DataSource = NVenta.Mostrar();
        }

        private void LimpiarTxtEnter()
        {
            Monto.Clear();
            txtdescripcion.Clear();
            txtdescripcion_Click(null, null);
            txtdescripcion.Focus();
        }//

        //Operaciones del usuario
        private void button1_Click(object sender, EventArgs e)
        {
            if (Insertar(txtdescripcion, Monto))
            {
                string rpt = "";
                if (UtilidadesFRM.LimiteCalculoPermitido(1, Convert.ToInt32(Monto.Text)))
                {
                    rpt = NVenta.Insertar(txtdescripcion.Text, Convert.ToInt32(Monto.Text));

                    if (rpt.Equals("OK"))
                    {
                        LimpiarTxtEnter();
                        dgViewVentas.DataSource = NVenta.Mostrar();

                    }
                }
                else
                    UtilidadesFRM.UsuarioMensajeInformation("Monto fuera del rango permitido");

            }
        }

        private void dgViewVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirDML();
        }//


    }
}
