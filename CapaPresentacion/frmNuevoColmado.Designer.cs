namespace CapaPresentacion
{
    partial class frmNuevoColmado
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
            this.txtnombrecolmado = new System.Windows.Forms.TextBox();
            this.txtnombrepropietario = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcapital = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblnombredelColmado = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblpropietario = new System.Windows.Forms.Label();
            this.lblcapitalinversion = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxcerrar
            // 
            this.pictureboxcerrar.Location = new System.Drawing.Point(527, 0);
            this.toolTipmensaje.SetToolTip(this.pictureboxcerrar, "Cerrar");
            this.pictureboxcerrar.Click += new System.EventHandler(this.pictureboxcerrar_Click);
            // 
            // pictureBoxmaximizar
            // 
            this.pictureBoxmaximizar.Location = new System.Drawing.Point(493, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxmaximizar, "Maximizar");
            // 
            // pictureBoxminimizar
            // 
            this.pictureBoxminimizar.Location = new System.Drawing.Point(425, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxminimizar, "Minimizar");
            // 
            // pictureBoxnormal
            // 
            this.pictureBoxnormal.Location = new System.Drawing.Point(459, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxnormal, "Normal");
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(563, 37);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Location = new System.Drawing.Point(154, 0);
            this.lbltitulo.Size = new System.Drawing.Size(243, 34);
            this.lbltitulo.Text = "Nuevo Colmado";
            // 
            // pictureBoxImgIcon
            // 
            this.pictureBoxImgIcon.Image = global::CapaPresentacion.Properties.Resources.ic_colmado32;
            this.pictureBoxImgIcon.Size = new System.Drawing.Size(32, 35);
            // 
            // txtnombrecolmado
            // 
            this.txtnombrecolmado.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecolmado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnombrecolmado.Location = new System.Drawing.Point(79, 69);
            this.txtnombrecolmado.Name = "txtnombrecolmado";
            this.txtnombrecolmado.Size = new System.Drawing.Size(217, 30);
            this.txtnombrecolmado.TabIndex = 0;
            this.txtnombrecolmado.Text = "Nombre del Colmado";
            this.txtnombrecolmado.Click += new System.EventHandler(this.txtnombrecolmado_Click);
            this.txtnombrecolmado.Enter += new System.EventHandler(this.txtnombrecolmado_Enter);
            // 
            // txtnombrepropietario
            // 
            this.txtnombrepropietario.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrepropietario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnombrepropietario.Location = new System.Drawing.Point(79, 121);
            this.txtnombrepropietario.Name = "txtnombrepropietario";
            this.txtnombrepropietario.Size = new System.Drawing.Size(217, 30);
            this.txtnombrepropietario.TabIndex = 2;
            this.txtnombrepropietario.Text = "Nombre del Propietario";
            this.txtnombrepropietario.Click += new System.EventHandler(this.txtnombrepropietario_Click);
            this.txtnombrepropietario.Enter += new System.EventHandler(this.txtnombrepropietario_Enter);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdireccion.Location = new System.Drawing.Point(79, 175);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(404, 30);
            this.txtdireccion.TabIndex = 4;
            this.txtdireccion.Text = "Dirección ";
            this.txtdireccion.Enter += new System.EventHandler(this.txtdireccion_Enter);
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txttelefono.Location = new System.Drawing.Point(305, 69);
            this.txttelefono.MaxLength = 10;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(178, 30);
            this.txttelefono.TabIndex = 1;
            this.txttelefono.Text = "Telefono";
            this.txttelefono.Click += new System.EventHandler(this.txttelefono_Click);
            this.txttelefono.Enter += new System.EventHandler(this.txttelefono_Enter);
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtcapital
            // 
            this.txtcapital.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapital.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtcapital.Location = new System.Drawing.Point(305, 121);
            this.txtcapital.MaxLength = 8;
            this.txtcapital.Name = "txtcapital";
            this.txtcapital.Size = new System.Drawing.Size(178, 30);
            this.txtcapital.TabIndex = 3;
            this.txtcapital.Text = "Capital de Inversión";
            this.txtcapital.Click += new System.EventHandler(this.txtcapital_Click);
            this.txtcapital.Enter += new System.EventHandler(this.txtcapital_Enter);
            this.txtcapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcapital_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::CapaPresentacion.Properties.Resources.ic_save22;
            this.btnguardar.Location = new System.Drawing.Point(189, 232);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(184, 45);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar Colmado";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblnombredelColmado
            // 
            this.lblnombredelColmado.AutoSize = true;
            this.lblnombredelColmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombredelColmado.ForeColor = System.Drawing.Color.Black;
            this.lblnombredelColmado.Location = new System.Drawing.Point(76, 53);
            this.lblnombredelColmado.Name = "lblnombredelColmado";
            this.lblnombredelColmado.Size = new System.Drawing.Size(123, 13);
            this.lblnombredelColmado.TabIndex = 7;
            this.lblnombredelColmado.Text = "Nombre del Colmado";
            this.lblnombredelColmado.Visible = false;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.ForeColor = System.Drawing.Color.Black;
            this.lbltelefono.Location = new System.Drawing.Point(302, 53);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(57, 13);
            this.lbltelefono.TabIndex = 8;
            this.lbltelefono.Text = "Telefono";
            this.lbltelefono.Visible = false;
            // 
            // lblpropietario
            // 
            this.lblpropietario.AutoSize = true;
            this.lblpropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpropietario.ForeColor = System.Drawing.Color.Black;
            this.lblpropietario.Location = new System.Drawing.Point(76, 105);
            this.lblpropietario.Name = "lblpropietario";
            this.lblpropietario.Size = new System.Drawing.Size(136, 13);
            this.lblpropietario.TabIndex = 9;
            this.lblpropietario.Text = "Nombre del Propietario";
            this.lblpropietario.Visible = false;
            // 
            // lblcapitalinversion
            // 
            this.lblcapitalinversion.AutoSize = true;
            this.lblcapitalinversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapitalinversion.ForeColor = System.Drawing.Color.Black;
            this.lblcapitalinversion.Location = new System.Drawing.Point(302, 105);
            this.lblcapitalinversion.Name = "lblcapitalinversion";
            this.lblcapitalinversion.Size = new System.Drawing.Size(120, 13);
            this.lblcapitalinversion.TabIndex = 10;
            this.lblcapitalinversion.Text = "Capital de Inversión";
            this.lblcapitalinversion.Visible = false;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(76, 159);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(61, 13);
            this.lbldireccion.TabIndex = 11;
            this.lbldireccion.Text = "Dirección";
            this.lbldireccion.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.ic_pen32;
            this.btnEditar.Location = new System.Drawing.Point(79, 211);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 30);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipmensaje.SetToolTip(this.btnEditar, "Habilitar Todos los Controles");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmNuevoColmado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(563, 316);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblcapitalinversion);
            this.Controls.Add(this.lblpropietario);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblnombredelColmado);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcapital);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombrepropietario);
            this.Controls.Add(this.txtnombrecolmado);
            this.Name = "frmNuevoColmado";
            this.Text = "frmNuevoColmado";
            this.Load += new System.EventHandler(this.frmNuevoColmado_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtnombrecolmado, 0);
            this.Controls.SetChildIndex(this.txtnombrepropietario, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            this.Controls.SetChildIndex(this.txttelefono, 0);
            this.Controls.SetChildIndex(this.txtcapital, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.lblnombredelColmado, 0);
            this.Controls.SetChildIndex(this.lbltelefono, 0);
            this.Controls.SetChildIndex(this.lblpropietario, 0);
            this.Controls.SetChildIndex(this.lblcapitalinversion, 0);
            this.Controls.SetChildIndex(this.lbldireccion, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombrecolmado;
        private System.Windows.Forms.TextBox txtnombrepropietario;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcapital;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblnombredelColmado;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblpropietario;
        private System.Windows.Forms.Label lblcapitalinversion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Button btnEditar;
    }
}