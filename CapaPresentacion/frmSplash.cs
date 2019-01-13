using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        int i = 0;
        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value = i++;

            
            if (i > 75)
            {
                lblmensaje.ForeColor = Color.FromArgb(255, 87, 34);
                lblmensaje.Text = "Abriendo archivos del systema";
            }
            if (i > 100)
            {
                timer1.Stop();
                new frmMenuBienvenida().Show();
                this.Hide();
            }
        }
    }
}
