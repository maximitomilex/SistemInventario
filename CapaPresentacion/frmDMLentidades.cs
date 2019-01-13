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
    public partial class frmDMLentidades : frmBase
    {
        public frmDMLentidades()
        {
            InitializeComponent();
           // CargarValoresIniciales();
        }

        public delegate void Actualizardgview(int i);
        public event Actualizardgview Actualizaciondgview;

        private string tabla;
        private int id;
        private int cantidad;
        private string descripcion;
        private int precio;

        private string montoText = "$ Precio";
        private string descripText = "Nombre";


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }


        //Diseño e interacion con el usuario
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesFRM.soloNumeroEnteros(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesFRM.soloNumeroEnteros(e);
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtCantidad, lblCantidad, "Cantidad");
            UtilidadesFRM.DeFocalizartxt(txtDescripcion, lblDescripcion, descripText);
            UtilidadesFRM.DeFocalizartxt(txtMonto, lblPrecio, montoText);
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad_Enter(null, e);
        }

        private void txtCantidad_TabStopChanged(object sender, EventArgs e)
        {
            UtilidadesFRM.DeFocalizartxt(txtCantidad, lblCantidad, "Cantidad");
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtDescripcion, lblDescripcion, descripText);
            UtilidadesFRM.DeFocalizartxt(txtMonto, lblPrecio, montoText);
            UtilidadesFRM.DeFocalizartxt(txtCantidad, lblCantidad, "Cantidad");
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            txtDescripcion_Enter(null, e);
        }

        private void txtMonto_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtMonto, lblPrecio, montoText);
            UtilidadesFRM.DeFocalizartxt(txtCantidad, lblCantidad, "Cantidad");
            UtilidadesFRM.DeFocalizartxt(txtDescripcion, lblDescripcion, descripText);

        }

        private void txtMonto_Click(object sender, EventArgs e)
        {
            txtMonto_Enter(null, e);
        }

        //Methods of process==============================>>>
        private void CargarValoresIniciales()
        {
            txtCantidad.Text = this.cantidad.ToString();
            txtDescripcion.Text = this.descripcion;
            txtMonto.Text = this.precio.ToString();

            if (!tabla.Equals("Mercancia"))
            {
                this.txtCantidad.Visible = false;
                this.lblCantidad.Visible = false;

                this.lblDescripcion.Location = new Point(97, 60);
                this.txtDescripcion.Location = new Point(100, 79);

                this.lblPrecio.Location = new Point(313, 60);
                this.txtMonto.Location = new Point(316, 79);

                montoText = "$ Monto";
                descripText = "Descripción";
            }

            lblDescripcion.Text = descripText;
            lblPrecio.Text = montoText;
            CargarImagenIconFrm();
        }

        private void CargarImagenIconFrm()
        {
            if (this.tabla.Equals("Mercancia"))
            {
                pictureBoxImgIcon.Image = Properties.Resources.ic_mercancias;
            }

            if (this.tabla.Equals("CuentaXCobrar"))
            {
                pictureBoxImgIcon.Image = Properties.Resources.ic_cxc4;
            }

            if (this.tabla.Equals("CuentaXPagar"))
            {
                pictureBoxImgIcon.Image = Properties.Resources.ic_cxp;
            }

            if (this.tabla.Equals("Venta"))
            {
                pictureBoxImgIcon.Image = Properties.Resources.ic_ventas2;
            }

            if (this.tabla.Equals("Gasto"))
            {
                pictureBoxImgIcon.Image = Properties.Resources.ic_gastos;
            }

            if (this.tabla.Equals("Efectivo"))
            {
                pictureBoxImgIcon.Image = Properties.Resources.ic_Efectivos;
            }
        }

        private string Eliminar()
        {
            string rpt = "";

            if (this.tabla.Equals("Mercancia"))
            {
                rpt = NMercancias.Eliminar(this.id);
            }

            if (this.tabla.Equals("CuentaXCobrar"))
            {
                rpt = NCuentaXCobrar.Eliminar(this.id);
            }

            if (this.tabla.Equals("CuentaXPagar"))
            {
                rpt = NCuentaXPagar.Eliminar(this.id);
            }

            if (this.tabla.Equals("Venta"))
            {
                rpt = NVenta.Eliminar(this.id);
            }

            if (this.tabla.Equals("Gasto"))
            {
                rpt = NGasto.Eliminar(this.id);
            }

            if (this.tabla.Equals("Efectivo"))
            {
                rpt = NEfectivos.Eliminar(this.id);
            }

            return rpt;
        }

        private string Guardar()
        {
            string rpt = "";
            if (this.tabla.Equals("Mercancia"))
            {
                if (UtilidadesFRM.LimiteCalculoPermitido(Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtMonto.Text)))
                {
                    rpt = NMercancias.Actualizar(this.id, txtDescripcion.Text, Convert.ToInt32(txtMonto.Text), Convert.ToInt32(txtCantidad.Text));
                }
                else
                    UtilidadesFRM.UsuarioMensajeInformation("Estos valores fuera del rango permitido");
            }

            if (this.tabla.Equals("CuentaXCobrar"))
            {
                rpt = NCuentaXCobrar.Actualizar(this.id, txtDescripcion.Text, Convert.ToInt32(txtMonto.Text));
            }

            if (this.tabla.Equals("CuentaXPagar"))
            {
                rpt = NCuentaXPagar.Actualizar(this.id, txtDescripcion.Text, Convert.ToInt32(txtMonto.Text));

            }

            if (this.tabla.Equals("Venta"))
            {
                rpt = NVenta.Actualizar(this.id, txtDescripcion.Text, Convert.ToInt32(txtMonto.Text));
            }

            if (this.tabla.Equals("Gasto"))
            {
                rpt = NGasto.Actualizar(this.id, txtDescripcion.Text, Convert.ToInt32(txtMonto.Text));
            }

            if (this.tabla.Equals("Efectivo"))
            {
                rpt = NEfectivos.Actualizar(this.id, txtDescripcion.Text, Convert.ToInt32(txtMonto.Text));
            }

            return rpt;
        }

        private bool Inserta(TextBox Cant, TextBox Nomb, TextBox Precio)
        {
            bool rpt = false;

            if (!tabla.Equals("Mercancia"))
            {
                if (UtilidadesFRM.validadtxt(Nomb, descripText) && UtilidadesFRM.validadtxt(Precio, montoText))
                {
                    rpt = true;
                }
            
            }
            else
              if (UtilidadesFRM.validadtxt(Cant, "Cantidad") && UtilidadesFRM.validadtxt(Nomb, descripText) && UtilidadesFRM.validadtxt(Precio, montoText))
            {
                rpt = true;
            }

            return rpt;
        }

        //Events of the control

        private void frmDMLentidades_Load(object sender, EventArgs e)
        {
            CargarValoresIniciales();
        }

       

        private void pictureboxcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Inserta(txtCantidad, txtDescripcion, txtMonto))
            {
                if (Guardar().Equals("OK"))
                {
                    Actualizaciondgview(0);
                    this.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Eliminar().Equals("OK"))
            {
                Actualizaciondgview(0);
                this.Close();
            }
        }

       
    }
}
