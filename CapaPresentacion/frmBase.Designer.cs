namespace CapaPresentacion
{
    partial class frmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxImgIcon = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pictureBoxminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxnormal = new System.Windows.Forms.PictureBox();
            this.pictureBoxmaximizar = new System.Windows.Forms.PictureBox();
            this.pictureboxcerrar = new System.Windows.Forms.PictureBox();
            this.toolTipmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxImgIcon);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Controls.Add(this.pictureBoxminimizar);
            this.panel1.Controls.Add(this.pictureBoxnormal);
            this.panel1.Controls.Add(this.pictureBoxmaximizar);
            this.panel1.Controls.Add(this.pictureboxcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxImgIcon
            // 
            this.pictureBoxImgIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxImgIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxImgIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImgIcon.Name = "pictureBoxImgIcon";
            this.pictureBoxImgIcon.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxImgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImgIcon.TabIndex = 1;
            this.pictureBoxImgIcon.TabStop = false;
            this.pictureBoxImgIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImgIcon_MouseDown);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(85, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(272, 34);
            this.lbltitulo.TabIndex = 5;
            this.lbltitulo.Text = "Inventory System";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbltitulo_MouseDown);
            // 
            // pictureBoxminimizar
            // 
            this.pictureBoxminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxminimizar.Image = global::CapaPresentacion.Properties.Resources.ic_minimizar;
            this.pictureBoxminimizar.Location = new System.Drawing.Point(307, 0);
            this.pictureBoxminimizar.Name = "pictureBoxminimizar";
            this.pictureBoxminimizar.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxminimizar.Size = new System.Drawing.Size(34, 35);
            this.pictureBoxminimizar.TabIndex = 3;
            this.pictureBoxminimizar.TabStop = false;
            this.toolTipmensaje.SetToolTip(this.pictureBoxminimizar, "Minimizar");
            this.pictureBoxminimizar.Click += new System.EventHandler(this.pictureBoxminimizar_Click);
            this.pictureBoxminimizar.MouseLeave += new System.EventHandler(this.pictureBoxminimizar_MouseLeave);
            this.pictureBoxminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxminimizar_MouseMove);
            // 
            // pictureBoxnormal
            // 
            this.pictureBoxnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxnormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxnormal.Image = global::CapaPresentacion.Properties.Resources.ic_max;
            this.pictureBoxnormal.Location = new System.Drawing.Point(341, 0);
            this.pictureBoxnormal.Name = "pictureBoxnormal";
            this.pictureBoxnormal.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxnormal.Size = new System.Drawing.Size(34, 35);
            this.pictureBoxnormal.TabIndex = 4;
            this.pictureBoxnormal.TabStop = false;
            this.toolTipmensaje.SetToolTip(this.pictureBoxnormal, "Normal");
            this.pictureBoxnormal.Click += new System.EventHandler(this.pictureBoxnormal_Click);
            this.pictureBoxnormal.MouseLeave += new System.EventHandler(this.pictureBoxnormal_MouseLeave);
            this.pictureBoxnormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxnormal_MouseMove);
            // 
            // pictureBoxmaximizar
            // 
            this.pictureBoxmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxmaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxmaximizar.Image = global::CapaPresentacion.Properties.Resources.ic_maximizar;
            this.pictureBoxmaximizar.Location = new System.Drawing.Point(375, 0);
            this.pictureBoxmaximizar.Name = "pictureBoxmaximizar";
            this.pictureBoxmaximizar.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxmaximizar.Size = new System.Drawing.Size(34, 35);
            this.pictureBoxmaximizar.TabIndex = 2;
            this.pictureBoxmaximizar.TabStop = false;
            this.toolTipmensaje.SetToolTip(this.pictureBoxmaximizar, "Maximizar");
            this.pictureBoxmaximizar.Click += new System.EventHandler(this.pictureBoxmaximizar_Click);
            this.pictureBoxmaximizar.MouseLeave += new System.EventHandler(this.pictureBoxmaximizar_MouseLeave);
            this.pictureBoxmaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxmaximizar_MouseMove);
            // 
            // pictureboxcerrar
            // 
            this.pictureboxcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxcerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureboxcerrar.Image = global::CapaPresentacion.Properties.Resources.ic_close;
            this.pictureboxcerrar.Location = new System.Drawing.Point(409, 0);
            this.pictureboxcerrar.Name = "pictureboxcerrar";
            this.pictureboxcerrar.Padding = new System.Windows.Forms.Padding(10);
            this.pictureboxcerrar.Size = new System.Drawing.Size(34, 35);
            this.pictureboxcerrar.TabIndex = 1;
            this.pictureboxcerrar.TabStop = false;
            this.toolTipmensaje.SetToolTip(this.pictureboxcerrar, "Cerrar");
            this.pictureboxcerrar.MouseLeave += new System.EventHandler(this.pictureboxcerrar_MouseLeave);
            this.pictureboxcerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureboxcerrar_MouseMove);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(445, 280);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox pictureboxcerrar;
        protected System.Windows.Forms.PictureBox pictureBoxmaximizar;
        protected System.Windows.Forms.PictureBox pictureBoxminimizar;
        protected System.Windows.Forms.PictureBox pictureBoxnormal;
        protected System.Windows.Forms.ToolTip toolTipmensaje;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label lbltitulo;
        protected System.Windows.Forms.PictureBox pictureBoxImgIcon;
    }
}