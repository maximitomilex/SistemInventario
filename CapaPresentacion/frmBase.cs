using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace CapaPresentacion
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
            this.pictureBoxnormal.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureboxcerrar_MouseMove(object sender, MouseEventArgs e)
        {
            pictureboxcerrar.BackColor = Color.FromArgb(211, 47, 47);
        }

        private void pictureboxcerrar_MouseLeave(object sender, EventArgs e)
        {
            pictureboxcerrar.BackColor =Color.FromArgb(38, 166, 154);
        }

        private void pictureBoxmaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxmaximizar.BackColor = Color.FromArgb(77, 182, 172);
        }

        private void pictureBoxmaximizar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxmaximizar.BackColor = Color.FromArgb(38, 166, 154);
        }

        private void pictureBoxnormal_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxnormal.BackColor = Color.FromArgb(77, 182, 172);
        }

        private void pictureBoxnormal_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxnormal.BackColor = Color.FromArgb(38, 166, 154);
        }

        private void pictureBoxminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxminimizar.BackColor = Color.FromArgb(77, 182, 172);
        }

        private void pictureBoxminimizar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxminimizar.BackColor = Color.FromArgb(38, 166, 154);
        }

        private void pictureBoxmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureBoxmaximizar.Visible = false;
            pictureBoxnormal.Visible = true;

        }

        private void pictureBoxnormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureBoxmaximizar.Visible = true;
            pictureBoxnormal.Visible = false;
        }

        private void pictureBoxminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxImgIcon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
