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
    public partial class frmEfectivos : Form
    {
        public frmEfectivos()
        {
            InitializeComponent();

            dgViewEfectivos.DataSource =NEfectivos.Mostrar();
            dgViewEfectivos.Columns["IdEfectivo"].Visible = false;
            dgViewEfectivos.Columns["Monto"].DefaultCellStyle.Format = "#,#";
        }

        public const string Nombre = "Efectivo";


        //Interfaz de usuario e interacion
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

        private void Monto_MouseClick(object sender, MouseEventArgs e)
        {
            Monto_Enter(null, e);
        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesFRM.soloNumeroEnteros(e);
        }//

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
                DML.Id = Convert.ToInt32(dgViewEfectivos.CurrentRow.Cells["IdEfectivo"].Value);
                // DML.Cantidad = Convert.ToInt32(dtgViewMercancias.CurrentRow.Cells["Cantidad"].Value);
                DML.Descripcion = dgViewEfectivos.CurrentRow.Cells["Descripcion"].Value.ToString();
                DML.Precio = Convert.ToInt32(dgViewEfectivos.CurrentRow.Cells["Monto"].Value);
                DML.Actualizaciondgview += new frmDMLentidades.Actualizardgview(actualizardgview);
                DML.ShowDialog();
            }
            catch
            {

            }
        }

        private void actualizardgview(int i)
        {
            dgViewEfectivos.DataSource = NEfectivos.Mostrar();
        }

        private void LimpiarTxtEnter()
        {
            Monto.Clear();
            txtdescripcion.Clear();
            txtdescripcion_Click(null, null);
            txtdescripcion.Focus();
        }//

        //Operaciones del usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Insertar(txtdescripcion, Monto))
            {
                string rpt = "";
                if (UtilidadesFRM.LimiteCalculoPermitido(1, Convert.ToInt32(Monto.Text)))
                {
                    rpt = NEfectivos.Insertar(txtdescripcion.Text, Convert.ToInt32(Monto.Text));

                    if (rpt.Equals("OK"))
                    {
                        LimpiarTxtEnter();
                        actualizardgview(0);

                    }
                }
                else
                    UtilidadesFRM.UsuarioMensajeInformation("Monto fuera del rango permitido");

            }
        }

        private void dgViewEfectivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirDML();
        }

    }
}
