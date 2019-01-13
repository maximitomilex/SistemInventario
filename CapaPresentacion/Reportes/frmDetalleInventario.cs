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
    public partial class frmDetalleInventario : frmBase
    {
        public frmDetalleInventario()
        {
            InitializeComponent();
            this.pictureBoxmaximizar.Visible = false;
        }

        private string _Tabla;
        private int _IdIventario;

        //Methods getter and setter
        public int IdIventario
        { 
            get{ return _IdIventario;}
            set { _IdIventario = value;}
        }

        public string Tabla
        {
            get { return _Tabla; }
            set { _Tabla = value; }
        }

        public delegate void Cerrar(string optionFrm);//Delagado 
        public event Cerrar CerrarFrm;   //Evento 

        private void frmDetalleInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.paMostrarInventariosDetalle' table. You can move, or remove it, as needed.
            this.paMostrarInventariosDetalleTableAdapter.Fill(this.DataSetPrincipal.paMostrarInventariosDetalle,this.IdIventario);
            // TODO: This line of code loads data into the 'DataSetPrincipal.paMostrarInventariosDetalle' table. You can move, or remove it, as needed.
             //this.paMostrarInventariosDetalleTableAdapter.Fill(this.DataSetPrincipal.paMostrarInventariosDetalle,12);
            
           // this.reportViewerInventario.RefreshReport();

            if (!this._Tabla.Equals("MenuDeOperaciones"))
            {
                lblFinalizar.Visible = false;
                lblRegresar.Visible = false;

                lblCerrar.Visible = true;
            }
            this.reportViewer1.RefreshReport();
        }

        private void lblRegresar_MouseMove(object sender, MouseEventArgs e)
        {
            lblRegresar.ForeColor = Color.FromArgb(51, 227, 255);
            lblRegresar.Font = new Font("Century", 14.75F,FontStyle.Bold);
            
        }

        private void lblRegresar_MouseLeave(object sender, EventArgs e)
        {
            lblRegresar.ForeColor = Color.White;
            lblRegresar.Font = new Font("Century", 14.25F, FontStyle.Bold);
        }

        private void lblFinalizar_MouseMove(object sender, MouseEventArgs e)
        {
            lblFinalizar.ForeColor = Color.FromArgb(76, 255, 51);
            lblFinalizar.Font = new Font("Century", 14.75F, FontStyle.Bold);
        }

        private void lblFinalizar_MouseLeave(object sender, EventArgs e)
        {
            lblFinalizar.ForeColor = Color.White;
            lblFinalizar.Font = new Font("Century", 14.25F, FontStyle.Bold);
        }

        private void lblFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere Finalizar este Inventario?\n\nUna vez Finalizado no se podra modificar su contenido", "Inventory System", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string rpt = "";// rpt = respuesta
                rpt=NInventario.VaciarTablas();

                if (rpt.Equals("OK"))
                {
                    CerrarFrm("Cerrar");//Delagado que apunta al method cerrarFrm of the class frmMenuDeOperaciones
                    this.Close();
                    frmMenuBienvenida Menu = new frmMenuBienvenida();
                    Menu.Show();
                }
            }
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            CerrarFrm("Actualizar");//Delagado que apunta al method cerrarFrm of the class frmMenuDeOperaciones
            this.Close();
        }

        private void lblCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            lblCerrar.ForeColor = Color.Red;
            lblCerrar.Font = new Font("Century", 14.75F, FontStyle.Bold);
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.White;
            lblCerrar.Font = new Font("Century", 14.25F, FontStyle.Bold);
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureboxcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
