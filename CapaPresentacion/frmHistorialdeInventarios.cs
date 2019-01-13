using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmHistorialdeInventarios : frmBase
    {
        public frmHistorialdeInventarios()
        {
            InitializeComponent();
            this.pictureBoxImgIcon.Image = Properties.Resources.ic_History;
            this.pictureBoxmaximizar.Visible = false;
            DesativarBtn();
        }

        public delegate void MostrarFrm(string p);
        public event MostrarFrm MostrandoFrm;

        private void pictureboxcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            MostrandoFrm("apd");//Es un evento del delegado MostrarFrm() //return data to parent Form
        }

        private void frmHistorialdeInventarios_Load(object sender, EventArgs e)
        {
            dtgViewHistorial.DataSource = NInventario.MostrarHistory();
            dtgViewHistorial.Columns["%Bruto"].DefaultCellStyle.Format = "#";//dar formato de numero entero
            dtgViewHistorial.Columns["IdInventario"].Visible = false;
        }

        private void dtgViewHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idInventario = Convert.ToInt32(dtgViewHistorial.CurrentRow.Cells["IdInventario"].Value.ToString());
                if (idInventario != 0)//Si hay datos
                    ActivarBtn();//
            }
            catch
            { 
                 
            }
        }


        //Activa los Button
        private void ActivarBtn() 
        {
            this.btnEliminar.Image = Properties.Resources.ic_delete32;
            this.btnEditar.Image = Properties.Resources.ic_editar32;
            this.btnEditar.FlatAppearance.BorderSize = 1;
            this.btnEliminar.FlatAppearance.BorderSize = 1;
            this.btnEliminar.Enabled = true;
            this.btnEditar.Enabled = true;
        }
        //Desativa los Button
        private void DesativarBtn()
        {
            this.btnEliminar.Image = null;
            this.btnEditar.Image = null;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;
            //dtgViewHistorial.ClearSelection();
        
        }

        private void btnEditar_Click(object sender, EventArgs e)//el nombre of this objeto en pantalla es Ver detalle
        {
            MostrarDetalleInventario();
            this.DesativarBtn(); 
        }

        private void MostrarDetalleInventario()
        {
            try
            {
                int idInventario = Convert.ToInt32(dtgViewHistorial.CurrentRow.Cells["IdInventario"].Value.ToString());
                frmDetalleInventario dtInventario = new frmDetalleInventario();
                dtInventario.IdIventario = idInventario;
                dtInventario.Tabla = Nombre;
                if(idInventario!=0)
                    dtInventario.ShowDialog();
            }
            catch(Exception error)
            {
                UtilidadesFRM.UsuarioMensajeInformation("Error: " + error.Message);
            }
        }

        private const string Nombre = "HistorialdeInventario";

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarInventario();
        }

        private void EliminarInventario()
        {
            try
            {
                string nombreColmado = dtgViewHistorial.CurrentRow.Cells["Colmado"].Value.ToString();
                string fecha = dtgViewHistorial.CurrentRow.Cells["Fecha"].Value.ToString();
                int idInventario = Convert.ToInt32(dtgViewHistorial.CurrentRow.Cells["IdInventario"].Value.ToString());

                if (MessageBox.Show("¿Quieres borrar este Inventario?\n\n" + "Colmado: " + nombreColmado + "\n\nFecha: " + fecha,
                    "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string rpt = NInventario.Eliminar(idInventario);
                    if (rpt.Equals("OK"))
                    {
                        dtgViewHistorial.DataSource = NInventario.MostrarHistory();
                        DesativarBtn();
                    }
                    else
                        UtilidadesFRM.UsuarioMensajeInformation("Error: " + rpt);
                }
                else
                    DesativarBtn();
            }
            catch (Exception error)
            {
                UtilidadesFRM.UsuarioMensajeInformation(error.Message);
            }
        }
    }
}
