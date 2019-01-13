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
    public partial class frmNuevoColmado : frmBase
    {
        public frmNuevoColmado()
        {
            InitializeComponent();
            this.pictureBoxmaximizar.Visible = false;
        }

        //Delgate and event
        public delegate void Actualizardtgview(int i);
        public event Actualizardtgview Actualizaciondtgview;

        //Interacion de interfaz de usuario
        private void txtnombrecolmado_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtnombrecolmado, lblnombredelColmado,"Nombre del Colmado");

            UtilidadesFRM.DeFocalizartxt(txtnombrepropietario, lblpropietario, "Nombre del Propietario");
            UtilidadesFRM.DeFocalizartxt(txttelefono, lbltelefono, "Telefono");
            UtilidadesFRM.DeFocalizartxt(txtcapital, lblcapitalinversion, "Capital de Inversión");
            UtilidadesFRM.DeFocalizartxt(txtdireccion, lbldireccion, "Dirección");
        }

        private void txtnombrecolmado_Click(object sender, EventArgs e)
        {
            txtnombrecolmado_Enter(null, e);
        }

        private void txttelefono_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txttelefono, lbltelefono, "Telefono");

            UtilidadesFRM.DeFocalizartxt(txtnombrecolmado, lblnombredelColmado, "Nombre del Colmado");
            UtilidadesFRM.DeFocalizartxt(txtnombrepropietario, lblpropietario, "Nombre del Propietario");
            UtilidadesFRM.DeFocalizartxt(txtcapital, lblcapitalinversion, "Capital de Inversión");
            UtilidadesFRM.DeFocalizartxt(txtdireccion, lbldireccion, "Dirección");
        }

        private void txttelefono_Click(object sender, EventArgs e)
        {
            txttelefono_Enter(null, e);
        }

        private void txtnombrepropietario_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtnombrepropietario, lblpropietario, "Nombre del Propietario");

            UtilidadesFRM.DeFocalizartxt(txttelefono, lbltelefono, "Telefono");
            UtilidadesFRM.DeFocalizartxt(txtnombrecolmado, lblnombredelColmado, "Nombre del Colmado");
            UtilidadesFRM.DeFocalizartxt(txtcapital, lblcapitalinversion, "Capital de Inversión");
            UtilidadesFRM.DeFocalizartxt(txtdireccion, lbldireccion, "Dirección");
        }

        private void txtnombrepropietario_Click(object sender, EventArgs e)
        {
            txtnombrepropietario_Enter(null, e);
        }

        private void txtcapital_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtcapital, lblcapitalinversion, "Capital de Inversión");

            UtilidadesFRM.DeFocalizartxt(txtnombrepropietario, lblpropietario, "Nombre del Propietario");
            UtilidadesFRM.DeFocalizartxt(txttelefono, lbltelefono, "Telefono");
            UtilidadesFRM.DeFocalizartxt(txtnombrecolmado, lblnombredelColmado, "Nombre del Colmado");
            UtilidadesFRM.DeFocalizartxt(txtdireccion, lbldireccion, "Dirección");
        }

        private void txtcapital_Click(object sender, EventArgs e)
        {
            txtcapital_Enter(null, e);
        }

        private void txtdireccion_Enter(object sender, EventArgs e)
        {
            UtilidadesFRM.Focalizartxt(txtdireccion, lbldireccion, "Dirección");

            UtilidadesFRM.DeFocalizartxt(txtcapital, lblcapitalinversion, "Capital de Inversión");
            UtilidadesFRM.DeFocalizartxt(txtnombrepropietario, lblpropietario, "Nombre del Propietario");
            UtilidadesFRM.DeFocalizartxt(txttelefono, lbltelefono, "Telefono");
            UtilidadesFRM.DeFocalizartxt(txtnombrecolmado, lblnombredelColmado, "Nombre del Colmado");
        }

        private void txtcapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesFRM.soloNumeroEnteros(e);
        }

        //Methods 
          private bool Inserta(TextBox Nombre, TextBox CapitalInversion)
        {
            bool rpt = false;
            if (UtilidadesFRM.validadtxt(Nombre,"Nombre del Colmado","El Nombre del Colmado es obligatorio") &&  UtilidadesFRM.validadtxt(CapitalInversion, "Capital de Inversión","Capital de Inversión es obligatorio"))
            {
                rpt = true;
            }
            
            return rpt;
        }

          private void Guardar()
          {
              string rpt = "";

              if (Inserta(txtnombrecolmado, txtcapital))
              {
                  string nombre = UtilidadesFRM.ReturnValorTXT(txtnombrecolmado, "Nombre del Colmado");
                  string telefono = UtilidadesFRM.ReturnValorTXT(txttelefono, "Telefono");
                  string nombrePropietario = UtilidadesFRM.ReturnValorTXT(txtnombrepropietario, "Nombre del Propietario");
                  string capitalInversion = UtilidadesFRM.ReturnValorTXT(txtcapital, "Capital de Inversión");
                  string direccion = UtilidadesFRM.ReturnValorTXT(txtdireccion, "Dirección");

                  if (UtilidadesFRM.LimiteCalculoPermitido(Convert.ToInt32(capitalInversion), 1))
                  {
                      if (tabla.Equals("Colmados"))//if is call from frmColmadosExistentes to update his datas
                      {
                          rpt = NColmado.Actualizar(Convert.ToInt32(this.IdColmado), nombre, direccion,
                                nombrePropietario, Convert.ToInt32(capitalInversion), telefono);
                      }
                      else
                      {
                          rpt = NColmado.Insertar(nombre, direccion,
                               nombrePropietario, Convert.ToInt32(capitalInversion), telefono);
                      }

                      if (rpt.Equals("OK"))
                      {
                          Actualizaciondtgview(0);
                          this.Close();
                      }
                  }
                  else
                      UtilidadesFRM.UsuarioMensajeInformation("EL valor del campo Capital de Inversión\nSobrepasan los limite del programa");
              }
          }

          private void frmNuevoColmado_Load(object sender, EventArgs e)
          {
              if (tabla.Equals("Colmados"))
              {
                  this.lbltitulo.Text = "Editar Colmado";
                  txtnombrecolmado.Text = this.nombre;
                  txtnombrecolmado.Enabled = false;
                  txtcapital.Enabled = false;
                  txtnombrepropietario.Text = this.nombrePropietario;
                  txttelefono.Text = this.telefono;
                  txtcapital.Text = this.capitalInversion;
                  txtdireccion.Text = this.direccion;
                  this.btnguardar.Text = "Guardar Cambios";
                  btnEditar.Visible = true;

              }
          }
          private void btnguardar_Click(object sender, EventArgs e)
          {
              Guardar();
          }

          private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
          {
              UtilidadesFRM.soloNumeroEnteros(e);
          }

         public string tabla = "";
         public string IdColmado = "";
         public string nombre="";
         public string telefono="";
         public string nombrePropietario="";
         public string capitalInversion="";
         public string direccion="";

         private void pictureboxcerrar_Click(object sender, EventArgs e)
         {
                 Actualizaciondtgview(1);
                 this.Close();
         }

         private void btnEditar_Click(object sender, EventArgs e)
         {
             this.txtcapital.Enabled = true;
             this.txtnombrecolmado.Enabled = true;
            // this.btnEditar.Visible = false;
         }
    }
}
