namespace CapaPresentacion
{
    partial class frmMenuDeOperaciones
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.lblGeneralresultado = new System.Windows.Forms.LinkLabel();
            this.pictureBoxmenu = new System.Windows.Forms.PictureBox();
            this.btnGasto = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCxP = new System.Windows.Forms.Button();
            this.btnCxC = new System.Windows.Forms.Button();
            this.btnMercancia = new System.Windows.Forms.Button();
            this.panelcontParents = new System.Windows.Forms.Panel();
            this.lblthisTitulo = new System.Windows.Forms.Label();
            this.lblnameColmado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxcerrar
            // 
            this.pictureboxcerrar.Location = new System.Drawing.Point(925, 0);
            this.toolTipmensaje.SetToolTip(this.pictureboxcerrar, "Cerrar");
            this.pictureboxcerrar.Click += new System.EventHandler(this.pictureboxcerrar_Click);
            // 
            // pictureBoxmaximizar
            // 
            this.pictureBoxmaximizar.Location = new System.Drawing.Point(891, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxmaximizar, "Maximizar");
            // 
            // pictureBoxminimizar
            // 
            this.pictureBoxminimizar.Location = new System.Drawing.Point(823, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxminimizar, "Minimizar");
            // 
            // pictureBoxnormal
            // 
            this.pictureBoxnormal.Location = new System.Drawing.Point(857, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxnormal, "Normal");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblnameColmado);
            this.panel1.Controls.Add(this.lblthisTitulo);
            this.panel1.Size = new System.Drawing.Size(961, 37);
            this.panel1.Controls.SetChildIndex(this.pictureBoxImgIcon, 0);
            this.panel1.Controls.SetChildIndex(this.pictureboxcerrar, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBoxmaximizar, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBoxnormal, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBoxminimizar, 0);
            this.panel1.Controls.SetChildIndex(this.lbltitulo, 0);
            this.panel1.Controls.SetChildIndex(this.lblthisTitulo, 0);
            this.panel1.Controls.SetChildIndex(this.lblnameColmado, 0);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltitulo.Location = new System.Drawing.Point(23208, 0);
            this.lbltitulo.Size = new System.Drawing.Size(330, 34);
            this.lbltitulo.Text = "Proceso de Inventario";
            // 
            // pictureBoxImgIcon
            // 
            this.pictureBoxImgIcon.Image = global::CapaPresentacion.Properties.Resources.ic_colmado32;
            this.pictureBoxImgIcon.Size = new System.Drawing.Size(32, 35);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(74)))), ((int)(((byte)(25)))));
            this.panelmenu.Controls.Add(this.lblGeneralresultado);
            this.panelmenu.Controls.Add(this.pictureBoxmenu);
            this.panelmenu.Controls.Add(this.btnGasto);
            this.panelmenu.Controls.Add(this.btnEfectivo);
            this.panelmenu.Controls.Add(this.btnVenta);
            this.panelmenu.Controls.Add(this.btnCxP);
            this.panelmenu.Controls.Add(this.btnCxC);
            this.panelmenu.Controls.Add(this.btnMercancia);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 37);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(214, 607);
            this.panelmenu.TabIndex = 1;
            // 
            // lblGeneralresultado
            // 
            this.lblGeneralresultado.ActiveLinkColor = System.Drawing.Color.White;
            this.lblGeneralresultado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblGeneralresultado.AutoSize = true;
            this.lblGeneralresultado.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralresultado.LinkColor = System.Drawing.Color.Aqua;
            this.lblGeneralresultado.Location = new System.Drawing.Point(9, 559);
            this.lblGeneralresultado.Name = "lblGeneralresultado";
            this.lblGeneralresultado.Size = new System.Drawing.Size(196, 23);
            this.lblGeneralresultado.TabIndex = 7;
            this.lblGeneralresultado.TabStop = true;
            this.lblGeneralresultado.Text = "Generar Resultado";
            this.lblGeneralresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGeneralresultado.Click += new System.EventHandler(this.lblGeneralresultado_Click);
            this.lblGeneralresultado.MouseLeave += new System.EventHandler(this.lblGeneralresultado_MouseLeave);
            this.lblGeneralresultado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblGeneralresultado_MouseMove);
            // 
            // pictureBoxmenu
            // 
            this.pictureBoxmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxmenu.Image = global::CapaPresentacion.Properties.Resources.imgcontable;
            this.pictureBoxmenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxmenu.Name = "pictureBoxmenu";
            this.pictureBoxmenu.Size = new System.Drawing.Size(214, 154);
            this.pictureBoxmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmenu.TabIndex = 6;
            this.pictureBoxmenu.TabStop = false;
            // 
            // btnGasto
            // 
            this.btnGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGasto.FlatAppearance.BorderSize = 0;
            this.btnGasto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnGasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGasto.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnGasto.Image = global::CapaPresentacion.Properties.Resources.ic_gastos;
            this.btnGasto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGasto.Location = new System.Drawing.Point(0, 470);
            this.btnGasto.Name = "btnGasto";
            this.btnGasto.Size = new System.Drawing.Size(214, 65);
            this.btnGasto.TabIndex = 5;
            this.btnGasto.Text = "Gastos";
            this.btnGasto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipmensaje.SetToolTip(this.btnGasto, "Total de Gastos Diarios o en un Periodo Determinado");
            this.btnGasto.UseVisualStyleBackColor = true;
            this.btnGasto.Click += new System.EventHandler(this.btnGasto_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEfectivo.FlatAppearance.BorderSize = 0;
            this.btnEfectivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEfectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfectivo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnEfectivo.Image = global::CapaPresentacion.Properties.Resources.ic_Efectivos;
            this.btnEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEfectivo.Location = new System.Drawing.Point(0, 403);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnEfectivo.Size = new System.Drawing.Size(214, 67);
            this.btnEfectivo.TabIndex = 4;
            this.btnEfectivo.Text = "Efectivos";
            this.btnEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipmensaje.SetToolTip(this.btnEfectivo, "Dinero en Caja o Banco");
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnVenta.Image = global::CapaPresentacion.Properties.Resources.ic_ventas2;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenta.Location = new System.Drawing.Point(0, 340);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnVenta.Size = new System.Drawing.Size(214, 63);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "Ventas";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipmensaje.SetToolTip(this.btnVenta, "Total de Ventas Diarias o en un determinado Periodo");
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCxP
            // 
            this.btnCxP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCxP.FlatAppearance.BorderSize = 0;
            this.btnCxP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCxP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnCxP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxP.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCxP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCxP.Image = global::CapaPresentacion.Properties.Resources.ic_cxp;
            this.btnCxP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCxP.Location = new System.Drawing.Point(0, 270);
            this.btnCxP.Name = "btnCxP";
            this.btnCxP.Size = new System.Drawing.Size(214, 70);
            this.btnCxP.TabIndex = 2;
            this.btnCxP.Text = "Cuenta por Pagar";
            this.btnCxP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipmensaje.SetToolTip(this.btnCxP, "Dinero Pendiente por Pagar");
            this.btnCxP.UseVisualStyleBackColor = true;
            this.btnCxP.Click += new System.EventHandler(this.btnCxP_Click);
            // 
            // btnCxC
            // 
            this.btnCxC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCxC.FlatAppearance.BorderSize = 0;
            this.btnCxC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCxC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxC.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCxC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCxC.Image = global::CapaPresentacion.Properties.Resources.ic_cxc4;
            this.btnCxC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCxC.Location = new System.Drawing.Point(0, 203);
            this.btnCxC.Name = "btnCxC";
            this.btnCxC.Size = new System.Drawing.Size(214, 67);
            this.btnCxC.TabIndex = 1;
            this.btnCxC.Text = "Cuenta por Cobrar";
            this.btnCxC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCxC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipmensaje.SetToolTip(this.btnCxC, "Dinero Pendiente por Cobrar");
            this.btnCxC.UseVisualStyleBackColor = true;
            this.btnCxC.Click += new System.EventHandler(this.btnCxC_Click);
            // 
            // btnMercancia
            // 
            this.btnMercancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMercancia.FlatAppearance.BorderSize = 0;
            this.btnMercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnMercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMercancia.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMercancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnMercancia.Image = global::CapaPresentacion.Properties.Resources.ic_mercancias;
            this.btnMercancia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMercancia.Location = new System.Drawing.Point(0, 154);
            this.btnMercancia.Name = "btnMercancia";
            this.btnMercancia.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMercancia.Size = new System.Drawing.Size(214, 49);
            this.btnMercancia.TabIndex = 0;
            this.btnMercancia.Text = "Mercancias";
            this.btnMercancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipmensaje.SetToolTip(this.btnMercancia, "Articulos Existentes");
            this.btnMercancia.UseVisualStyleBackColor = true;
            this.btnMercancia.Click += new System.EventHandler(this.btnMercancia_Click);
            // 
            // panelcontParents
            // 
            this.panelcontParents.Location = new System.Drawing.Point(214, 37);
            this.panelcontParents.Name = "panelcontParents";
            this.panelcontParents.Size = new System.Drawing.Size(659, 518);
            this.panelcontParents.TabIndex = 2;
            // 
            // lblthisTitulo
            // 
            this.lblthisTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblthisTitulo.AutoSize = true;
            this.lblthisTitulo.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthisTitulo.ForeColor = System.Drawing.Color.White;
            this.lblthisTitulo.Location = new System.Drawing.Point(343, 0);
            this.lblthisTitulo.Name = "lblthisTitulo";
            this.lblthisTitulo.Size = new System.Drawing.Size(330, 34);
            this.lblthisTitulo.TabIndex = 6;
            this.lblthisTitulo.Text = "Proceso de Inventario";
            this.lblthisTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnameColmado
            // 
            this.lblnameColmado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblnameColmado.AutoSize = true;
            this.lblnameColmado.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameColmado.ForeColor = System.Drawing.Color.White;
            this.lblnameColmado.Location = new System.Drawing.Point(32, 7);
            this.lblnameColmado.Name = "lblnameColmado";
            this.lblnameColmado.Size = new System.Drawing.Size(86, 20);
            this.lblnameColmado.TabIndex = 7;
            this.lblnameColmado.Text = "Colmado ";
            this.lblnameColmado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenuDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 644);
            this.Controls.Add(this.panelcontParents);
            this.Controls.Add(this.panelmenu);
            this.Name = "frmMenuDeOperaciones";
            this.Text = "frmMenuDeOperaciones";
            this.Load += new System.EventHandler(this.frmMenuDeOperaciones_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelmenu, 0);
            this.Controls.SetChildIndex(this.panelcontParents, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelcontParents;
        private System.Windows.Forms.Button btnMercancia;
        private System.Windows.Forms.Button btnGasto;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCxP;
        private System.Windows.Forms.Button btnCxC;
        protected System.Windows.Forms.Label lblthisTitulo;
        private System.Windows.Forms.PictureBox pictureBoxmenu;
        private System.Windows.Forms.LinkLabel lblGeneralresultado;
        protected System.Windows.Forms.Label lblnameColmado;

    }
}