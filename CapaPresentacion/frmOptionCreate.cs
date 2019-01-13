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
    public partial class frmOptionCreate : frmBase
    {
        public frmOptionCreate()
        {
            InitializeComponent();
            dtgViewColmado.DataSource = NColmado.Mostrar();
            dtgViewColmado.Columns["IdColmado"].Visible = false;
            dtgViewColmado.Columns["Inversion"].DefaultCellStyle.Format = "#,#";
            
        }

        public delegate void MostrarFrm(string p);
        public event MostrarFrm MostrandoFrm;

        private string nombre, telefono, nombrePropietario, capitalInversion;

        public const string Nombre = "OptionCreate";
        //Methods

        public void actualizardgview(int i)
        {
            dtgViewColmado.DataSource = CapaNegocios.NColmado.Mostrar();
            dtgViewColmado.ClearSelection();
        
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            txtbuscar.Visible = true;
            cboxbuscar.Visible = true;
            txtbuscar.Focus();
            btnbuscar.Location = new Point(661,71);
            cboxbuscar.SelectedItem = "Nombre";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            frmNuevoColmado colmadonuevo = new frmNuevoColmado();
            colmadonuevo.Actualizaciondtgview+= new frmNuevoColmado.Actualizardtgview(this.actualizardgview);
            colmadonuevo.ShowDialog();
        }

        private void frmOptionCreate_Load(object sender, EventArgs e)
        {
            dtgViewColmado.ClearSelection();
        }

        private void dtgViewColmado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                frmMenuDeOperaciones.IdColmado = dtgViewColmado.CurrentRow.Cells["IdColmado"].Value.ToString();
                this.idColmado = Convert.ToInt32(dtgViewColmado.CurrentRow.Cells["IdColmado"].Value.ToString());
                nombre = dtgViewColmado.CurrentRow.Cells["Nombre"].Value.ToString();
                frmMenuDeOperaciones.NombreColmado = nombre;
                nombrePropietario = dtgViewColmado.CurrentRow.Cells["Propietario"].Value.ToString();
                capitalInversion = dtgViewColmado.CurrentRow.Cells["Inversion"].Value.ToString();
                telefono = dtgViewColmado.CurrentRow.Cells["Telefono"].Value.ToString();
            }
            catch 
            { 
            
            }

        }

        private void dtgViewColmado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ComenzarInventario();
            dtgViewColmado.ClearSelection();
            
        }

        private void ComenzarInventario()
        {
            if (this.idColmado > 0)//Para validar IdColmado 
            {
                DialogResult resul;
                resul = MessageBox.Show("¿Quieres comenzar el Inventario a el Colmado " + nombre + "?\n\nPropietario: " + nombrePropietario
                , "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resul == DialogResult.Yes)
                {
                    //Poner un splash para mejorar el dise;o de la interfaz idea
                    frmMenuDeOperaciones frm = new frmMenuDeOperaciones();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }
        private void dtgViewColmado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ComenzarInventario();
                dtgViewColmado.ClearSelection();
            }
            else
            {
                if (dtgViewColmado.RowCount == 1)
                {
                    dtgViewColmado.DataSource = NColmado.Mostrar();
                }
            }
        }

        private void pictureboxcerrar_Click(object sender, EventArgs e)//X
        {
            this.Close();
            MostrandoFrm("j");
        }

        public void CerrarFrmAnteriores(string p)
        {
            MostrandoFrm("");//Evento
            this.Close();
        }

        private int idColmado;
    }
}
