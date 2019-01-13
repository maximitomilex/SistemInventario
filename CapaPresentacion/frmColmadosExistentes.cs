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
    public partial class frmColmadosExistentes : frmBase
    {
        public frmColmadosExistentes()
        {
            InitializeComponent();
            pictureBoxmaximizar.Visible = false;

            DesahabilitarBotones();
        }

        public delegate void MostrarFrm(string p);
        public event MostrarFrm MostrandoFrm;

        public const string Nombre = "Colmados";

        private void frmColmadosExistentes_Load(object sender, EventArgs e)
        {
            try
            {
                actualizadtgview(1);
                dtgViewColmado.Columns["IdColmado"].Visible = false;
                dtgViewColmado.Columns["Inversion"].DefaultCellStyle.Format = "#,#";
            }
            catch 
            { 
            
            }

            //0; 192; 0 color btn eliminar y editar

        }

        private void dtgViewColmado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotones();
        }

        private void HabilitarBotones()
        {
            this.btnEliminar.Image = Properties.Resources.ic_delete32;
            this.btnEliminar.FlatAppearance.BorderColor = Color.Red;

            this.btnEditar.Image = Properties.Resources.ic_editar32;
            this.btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);

           this.btnEliminar.Enabled = true;
           this.btnEditar.Enabled = true;
        }

        private void DesahabilitarBotones()
        {
            this.btnEliminar.Image = null;
            this.btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(38, 50, 56);

            this.btnEditar.Image = null;
            this.btnEditar.FlatAppearance.BorderColor = Color.FromArgb(38, 50, 56);

            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;

        }

        private void actualizadtgview(int i)
        {
            try
            {
                dtgViewColmado.DataSource = NColmado.Mostrar();
                dtgViewColmado.ClearSelection();
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DesahabilitarBotones();
            frmNuevoColmado nuevocolmado = new frmNuevoColmado();
            nuevocolmado.Actualizaciondtgview += new frmNuevoColmado.Actualizardtgview(actualizadtgview);
            nuevocolmado.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmNuevoColmado nuevocolmado = new frmNuevoColmado();
                nuevocolmado.tabla = Nombre;
                nuevocolmado.IdColmado = dtgViewColmado.CurrentRow.Cells["IdColmado"].Value.ToString();
                nuevocolmado.nombre = dtgViewColmado.CurrentRow.Cells["Nombre"].Value.ToString();
                nuevocolmado.nombrePropietario = dtgViewColmado.CurrentRow.Cells["Propietario"].Value.ToString();
                nuevocolmado.telefono = dtgViewColmado.CurrentRow.Cells["Telefono"].Value.ToString();
                nuevocolmado.direccion = dtgViewColmado.CurrentRow.Cells["Direccion"].Value.ToString();
                nuevocolmado.capitalInversion = dtgViewColmado.CurrentRow.Cells["Inversion"].Value.ToString();
                nuevocolmado.Actualizaciondtgview += new frmNuevoColmado.Actualizardtgview(actualizadtgview);
                nuevocolmado.ShowDialog();
                DesahabilitarBotones();
            }
            catch
            { 
            
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDG;
            int id =Convert.ToInt32(dtgViewColmado.CurrentRow.Cells["IdColmado"].Value.ToString());
            string nombreColmado = dtgViewColmado.CurrentRow.Cells["Nombre"].Value.ToString();
            string rpt = "";
            resultadoDG = MessageBox.Show("¿Esta seguro de querer eliminar el colmado " + nombreColmado + "?" +
                "\n\n Perderá todos los datos Relacionados", "Inventory System", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            DesahabilitarBotones();


            if (resultadoDG == DialogResult.Yes)
            {
                rpt = NColmado.Eliminar(id);

                if (rpt.Equals("OK"))
                {
                    actualizadtgview(0);
                }

            }
            else
                dtgViewColmado.ClearSelection();
        }

        private void pictureboxcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            MostrandoFrm("j");
        }

        private void dtgViewColmado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                HabilitarBotones();
            }
        }
     
    }
}
