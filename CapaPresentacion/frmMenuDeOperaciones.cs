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
    public partial class frmMenuDeOperaciones : frmBase
    {
        public frmMenuDeOperaciones()
        {
            InitializeComponent();
            this.lbltitulo.Visible = false;//para no hacer visible este elemento de frmBase (Herencia)
            AbrirFormHijo(new frmMercancias());
            putBtnBackColor(btnMercancia, Color.FromArgb(38, 50, 56));

            this.panelcontParents.Dock = DockStyle.Fill;
        }

        //Methods 
        private void AbrirFormHijo(object frmHijo)
        {
            if (this.panelcontParents.Controls.Count > 0)
                this.panelcontParents.Controls.RemoveAt(0);

            Form fh = frmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontParents.Controls.Add(fh);
            this.panelcontParents.Tag = fh;
            fh.Show();

        }
        //=================All desing interativo de la interfaz de usuario
        private void putBtnBackColor(Button btn,Color color)
        {
            btn.BackColor = color;
        }
        //El setter el BackColor de los Buttons
        private void BotonesBackColor()
        {
            putBtnBackColor(btnMercancia, Color.FromArgb(230, 74, 25));
            putBtnBackColor(btnCxC, Color.FromArgb(230, 74, 25));
            putBtnBackColor(btnCxP, Color.FromArgb(230, 74, 25));
            putBtnBackColor(btnVenta, Color.FromArgb(230, 74, 25));
            putBtnBackColor(btnGasto, Color.FromArgb(230, 74, 25));
            putBtnBackColor(btnEfectivo, Color.FromArgb(230, 74, 25));

            //Llamada a el methods : BtnMouseOverBackColor
            BtnMouseOverBackColor();
        }
        //Cuando el Mouse pase o se posiciones sobre el Button
        private void putBtnMouseOverBackColor(Button boton, Color color)
        {
            boton.FlatAppearance.MouseOverBackColor = color;        
        }
        //Setter all Button with the method putBtnMouseOverBackColor
        private void BtnMouseOverBackColor()
        {
            putBtnMouseOverBackColor(btnMercancia, Color.FromArgb(255, 112, 67));
            putBtnMouseOverBackColor(btnCxC, Color.FromArgb(255, 112, 67));
            putBtnMouseOverBackColor(btnCxP, Color.FromArgb(255, 112, 67));
            putBtnMouseOverBackColor(btnVenta, Color.FromArgb(255, 112, 67));
            putBtnMouseOverBackColor(btnGasto, Color.FromArgb(255, 112, 67));
            putBtnMouseOverBackColor(btnEfectivo, Color.FromArgb(255, 112, 67));
        }
      
        private void btnCxC_Click(object sender, EventArgs e)
        {
            BotonesBackColor();
            putBtnBackColor(btnCxC, Color.FromArgb(38, 50, 56));
            putBtnMouseOverBackColor(btnCxC, Color.FromArgb(38, 50, 56));
            AbrirFormHijo(new frmCuentaXCobrar());
        }

        private void btnMercancia_Click(object sender, EventArgs e)
        {
            BotonesBackColor();
            putBtnBackColor(btnMercancia, Color.FromArgb(38, 50, 56));
            putBtnMouseOverBackColor(btnMercancia, Color.FromArgb(38, 50, 56));
            AbrirFormHijo(new frmMercancias());
        }

        private void btnCxP_Click(object sender, EventArgs e)
        {
            BotonesBackColor();
            putBtnBackColor(btnCxP, Color.FromArgb(38, 50, 56));
            putBtnMouseOverBackColor(btnCxP, Color.FromArgb(38, 50, 56));
            AbrirFormHijo(new frmCuentaXPagar());
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            BotonesBackColor();
            putBtnBackColor(btnVenta, Color.FromArgb(38, 50, 56));
            putBtnMouseOverBackColor(btnVenta, Color.FromArgb(38, 50, 56));
            AbrirFormHijo(new frmVentas());
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            BotonesBackColor();
            putBtnBackColor(btnEfectivo, Color.FromArgb(38, 50, 56));
            putBtnMouseOverBackColor(btnEfectivo, Color.FromArgb(38, 50, 56));
            AbrirFormHijo(new frmEfectivos());
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            BotonesBackColor();
            putBtnBackColor(btnGasto, Color.FromArgb(38, 50, 56));
            putBtnMouseOverBackColor(btnGasto, Color.FromArgb(38, 50, 56));
            AbrirFormHijo(new frmGastos());
        }

        private void lblGeneralresultado_MouseMove(object sender, MouseEventArgs e)
        {
             //Cambiar el tamaño del lblGeneralresultado a un tamaño mas alto 
            lblGeneralresultado.Font = new Font("Century", 15,FontStyle.Bold);
        }

        private void lblGeneralresultado_MouseLeave(object sender, EventArgs e)
        {
            lblGeneralresultado.Font = new Font("Century", 14,FontStyle.Bold);
            //Regresar el tamaño del lblGeneralresultado a su tamaño original
        }
        //========================= end

        private void frmMenuDeOperaciones_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.pictureBoxmaximizar.Visible = false;
            this.pictureBoxnormal.Visible = true;
            lblnameColmado.Text = lblnameColmado.Text + NombreColmado;
        }

      

        private void lblGeneralresultado_Click(object sender, EventArgs e)
        {
            generalResultado();

           //lblGeneralresultado.Text = NInventario.MostrarLastIdInventario().ToString();
        }
        private void pictureboxcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                if (InventarioProceso() || isGeneratesInventario)
                {
                    if (MessageBox.Show("¿Desea guardar este inventario para continuar despues?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        new frmMenuBienvenida().Show();
                        this.Hide();
                    }
                    else
                    {
                        if (isGeneratesInventario)//Si el Registro o Actualizacion del inventario se realizo
                            NInventario.Eliminar(NInventario.MostrarLastIdInventario());

                        NInventario.VaciarTablas();
                        new frmMenuBienvenida().Show();
                        this.Hide();
                    }
                }
                else
                {
                    NInventario.VaciarTablas();
                    new frmMenuBienvenida().Show();
                    this.Hide();
                }
                
            }

        }
        //Methods 
        private void generalResultado()
        {
            isGeneratesInventario = true;
            string rpt = "";
            if (AccionDB.Equals("Guardar"))
            {
                rpt = NInventario.Insertar(Convert.ToInt32(IdColmado));
            }
            else
            {
                rpt = NInventario.Actualizar(NInventario.MostrarLastIdInventario());
            }

            if (rpt.Equals("OK"))
            {
                if (NInventario.MostrarLastIdInventario() > 0)
                {
                    try
                    {
                        // this.Hide(); this una prueba
                        frmDetalleInventario detalle = new frmDetalleInventario();
                        detalle.IdIventario = NInventario.MostrarLastIdInventario();//Se obtiene el id del last inventario
                        detalle.Tabla = Nombre;
                        detalle.CerrarFrm+= new frmDetalleInventario.Cerrar(cerrarFrm);
                        detalle.ShowDialog();
                    }
                    catch(Exception error)
                    { 
                         UtilidadesFRM.UsuarioMensajeInformation(error.Message);
                    }
                }
            }


        }

        public void cerrarFrm(string opcionfrm)
        {
            if (opcionfrm.Equals("Cerrar"))
            {
                this.Close();
            }
            else
            {
                AccionDB = "Actualizar";
            }
       
        }
        private bool InventarioProceso()//Si algunas de las tabla de la DB tienen registros o no
        {
            if (NMercancias.Mostrar().Rows.Count != 0 || NCuentaXCobrar.Mostrar().Rows.Count != 0 ||
                NCuentaXPagar.Mostrar().Rows.Count != 0 || NVenta.Mostrar().Rows.Count != 0 || NEfectivos.Mostrar().Rows.Count != 0
                || NGasto.Mostrar().Rows.Count != 0)
            {

                return true;
            }
            else
                return false;
        }
    

        //Actributos
        public static string AccionDB = "Guardar";
        public static string IdColmado = "";
        public static string NombreColmado = "";
        public const string Nombre = "MenuDeOperaciones";
        private bool isGeneratesInventario = false;

      
    }
}
