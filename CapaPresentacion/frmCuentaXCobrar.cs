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
    public partial class frmCuentaXCobrar : Form
    {
        public frmCuentaXCobrar()
        {
            InitializeComponent();

            dtgViewCxC.DataSource = NCuentaXCobrar.Mostrar();
            dtgViewCxC.Columns["IdCuentaXCobrar"].Visible = false;
            dtgViewCxC.Columns["Monto"].DefaultCellStyle.Format = "#,#";
        }
        public const string Nombre = "CuentaXCobrar";


        //Diseño y interacion con el usuario
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

        private void Monto_TabStopChanged(object sender, EventArgs e)
        {
            UtilidadesFRM.DeFocalizartxt(Monto, lblmonto, "$ Monto");
        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesFRM.soloNumeroEnteros(e);
        }

        //Methods
        private bool Insertar(TextBox txtdescripcion, TextBox monto)
        {
            bool rpt = false;

            if (UtilidadesFRM.validadtxt(txtdescripcion, "Descripción") && UtilidadesFRM.validadtxt(monto, "$ Monto"))
            {
                rpt = true;
            }

            return rpt;
        }

        private void LimpiarTxtEnter()
        {
            Monto.Clear();
            txtdescripcion.Clear();
            txtdescripcion_Click(null, null);
            txtdescripcion.Focus();
        }

        private void AbrirDML()
        {
            try
            {
                frmDMLentidades DML = new frmDMLentidades();
                DML.Tabla = Nombre;
                DML.Id = Convert.ToInt32(dtgViewCxC.CurrentRow.Cells["IdCuentaXCobrar"].Value);
                // DML.Cantidad = Convert.ToInt32(dtgViewMercancias.CurrentRow.Cells["Cantidad"].Value);
                DML.Descripcion = dtgViewCxC.CurrentRow.Cells["Descripcion"].Value.ToString();
                DML.Precio = Convert.ToInt32(dtgViewCxC.CurrentRow.Cells["Monto"].Value);
                DML.Actualizaciondgview += new frmDMLentidades.Actualizardgview(actualizardgview);
                DML.ShowDialog();
            }
            catch
            { 
                 
            }
        }

        private void actualizardgview(int i)
        {
            dtgViewCxC.DataSource = NCuentaXCobrar.Mostrar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Insertar(txtdescripcion, Monto))
            {
                string rpt = "";
                if (UtilidadesFRM.LimiteCalculoPermitido(1, Convert.ToInt32(Monto.Text)))
                {
                    rpt = NCuentaXCobrar.Insertar(txtdescripcion.Text, Convert.ToInt32(Monto.Text));

                    if (rpt.Equals("OK"))
                    {
                        LimpiarTxtEnter();
                        dtgViewCxC.DataSource = NCuentaXCobrar.Mostrar();
                      
                    }
                }
                else
                    UtilidadesFRM.UsuarioMensajeInformation("Monto fuera del rango permitido");
               
            }
        }

        private void dtgViewCxC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirDML();
        }

    }
}
