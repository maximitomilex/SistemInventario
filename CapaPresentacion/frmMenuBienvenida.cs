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
    public partial class frmMenuBienvenida : frmBase
    {
        public frmMenuBienvenida()
        {
            InitializeComponent();

            dtgviewhistorial.DataSource = NInventario.Mostrar();
            dtgviewhistorial.Columns["IdInventario"].Visible = false;
            pictureBoxnormal.Visible = false;
            pictureBoxmaximizar.Visible = false;            
        }

        private void lblcrearinventario_MouseMove(object sender, MouseEventArgs e)
        {
            lblcrearinventario.ForeColor = Color.White;
            lblcrearinventario.Font = new Font("Comic Sans MS", 15.25F);
        }

        private void lblcrearinventario_MouseLeave(object sender, EventArgs e)
        {
            lblcrearinventario.Font = new Font("Comic Sans MS", 15);
            lblcrearinventario.ForeColor = SystemColors.AppWorkspace;
        }

        private void lblHistorialInventarios_MouseMove(object sender, MouseEventArgs e)
        {
            lblHistorialInventarios.Font = new Font("Comic Sans MS", 15.25F);
            lblHistorialInventarios.ForeColor = Color.White;
        }

        private void lblHistorialInventarios_MouseLeave(object sender, EventArgs e)
        {
            lblHistorialInventarios.Font = new Font("Comic Sans MS", 15);
            lblHistorialInventarios.ForeColor = SystemColors.AppWorkspace;
        }

        //THis una opcion para los Inventarios pendientes
       /* private void lblInventariosPendientes_MouseMove(object sender, MouseEventArgs e)
        {
            lblInventariosPendientes.Font = new Font("Comic Sans MS", 15.25F);
            lblInventariosPendientes.ForeColor = Color.White;
        }

        private void lblInventariosPendientes_MouseLeave(object sender, EventArgs e)
        {
            lblInventariosPendientes.Font = new Font("Comic Sans MS", 15);
            lblInventariosPendientes.ForeColor = SystemColors.AppWorkspace;
        }*/

        private void lblAyuda_MouseMove(object sender, MouseEventArgs e)
        {
            lblAyuda.Font = new Font("Comic Sans MS", 15.25F);
            lblAyuda.ForeColor = Color.White;
        }

        private void lblAyuda_MouseLeave(object sender, EventArgs e)
        {
            lblAyuda.Font = new Font("Comic Sans MS", 15);
            lblAyuda.ForeColor = SystemColors.AppWorkspace;
        }

        private void lblColmados_MouseMove(object sender, MouseEventArgs e)
        {
            lblColmados.Font = new Font("Comic Sans MS", 15.25F);
            lblColmados.ForeColor = Color.White;
        }

        private void lblColmados_MouseLeave(object sender, EventArgs e)
        {
            lblColmados.Font = new Font("Comic Sans MS", 15);
            lblColmados.ForeColor = SystemColors.AppWorkspace;
        }
        private void lblcrearinventario_Click(object sender, EventArgs e)
        {
            frmOptionCreate frm = new frmOptionCreate();
            frm.MostrandoFrm+= new frmOptionCreate.MostrarFrm(MostrarFrm);//Llamado a delegado
            this.Hide();
            frm.Show();
            
        }

        private void lblColmados_Click(object sender, EventArgs e)
        {
            frmColmadosExistentes frm = new frmColmadosExistentes();
            frm.MostrandoFrm += new frmColmadosExistentes.MostrarFrm(MostrarFrm);
            this.Hide();
            frm.Show();
        }

        private void frmMenuBienvenida_Load(object sender, EventArgs e)
        {
            dtgviewhistorial.ClearSelection();
        }

        private void lblHistorialInventarios_Click(object sender, EventArgs e)
        {
          frmHistorialdeInventarios frm = new frmHistorialdeInventarios();
          frm.MostrandoFrm += new frmHistorialdeInventarios.MostrarFrm(MostrarFrm);
          this.Hide();
          frm.Show();
        }

        private void dtgviewhistorial_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void pictureboxcerrar_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

        public void MostrarFrm(string p)
        {
            this.Show();
        }
        
    }
}
