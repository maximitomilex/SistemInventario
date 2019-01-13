namespace CapaPresentacion
{
    partial class frmMercancias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgViewMercancias = new System.Windows.Forms.DataGridView();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.toolTipMensajeUsuarios = new System.Windows.Forms.ToolTip(this.components);
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewMercancias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgViewMercancias
            // 
            this.dtgViewMercancias.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtgViewMercancias.AllowUserToAddRows = false;
            this.dtgViewMercancias.AllowUserToDeleteRows = false;
            this.dtgViewMercancias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgViewMercancias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgViewMercancias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgViewMercancias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgViewMercancias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dtgViewMercancias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgViewMercancias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgViewMercancias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgViewMercancias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgViewMercancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewMercancias.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgViewMercancias.EnableHeadersVisualStyles = false;
            this.dtgViewMercancias.Location = new System.Drawing.Point(60, 110);
            this.dtgViewMercancias.MultiSelect = false;
            this.dtgViewMercancias.Name = "dtgViewMercancias";
            this.dtgViewMercancias.ReadOnly = true;
            this.dtgViewMercancias.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgViewMercancias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgViewMercancias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViewMercancias.Size = new System.Drawing.Size(626, 343);
            this.dtgViewMercancias.StandardTab = true;
            this.dtgViewMercancias.TabIndex = 4;
            this.dtgViewMercancias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewMercancias_CellDoubleClick);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtcantidad.Location = new System.Drawing.Point(76, 514);
            this.txtcantidad.MaxLength = 4;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(96, 29);
            this.txtcantidad.TabIndex = 0;
            this.txtcantidad.Text = "Cantidad";
            this.toolTipMensajeUsuarios.SetToolTip(this.txtcantidad, "Cantidad de un Producto");
            this.txtcantidad.Click += new System.EventHandler(this.txtcantidad_Click);
            this.txtcantidad.TabStopChanged += new System.EventHandler(this.txtcantidad_TabStopChanged);
            this.txtcantidad.Enter += new System.EventHandler(this.txtcantidad_Enter);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // Monto
            // 
            this.Monto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Monto.Location = new System.Drawing.Point(434, 514);
            this.Monto.MaxLength = 8;
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(114, 29);
            this.Monto.TabIndex = 2;
            this.Monto.Text = "$ Precio";
            this.toolTipMensajeUsuarios.SetToolTip(this.Monto, "Precio Unidad o Caja del Producto");
            this.Monto.Click += new System.EventHandler(this.Monto_Click);
            this.Monto.TextChanged += new System.EventHandler(this.Monto_TextChanged);
            this.Monto.Enter += new System.EventHandler(this.Monto_Enter);
            this.Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Monto_KeyPress);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdescripcion.Location = new System.Drawing.Point(220, 514);
            this.txtdescripcion.MaxLength = 40;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(166, 29);
            this.txtdescripcion.TabIndex = 1;
            this.txtdescripcion.Text = "Nombre";
            this.toolTipMensajeUsuarios.SetToolTip(this.txtdescripcion, "Nombre del Producto o Descripción");
            this.txtdescripcion.Click += new System.EventHandler(this.txtdescripcion_Click);
            this.txtdescripcion.Enter += new System.EventHandler(this.txtdescripcion_Enter);
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::CapaPresentacion.Properties.Resources.ic_saveG;
            this.btnguardar.Location = new System.Drawing.Point(596, 498);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 67);
            this.btnguardar.TabIndex = 3;
            this.toolTipMensajeUsuarios.SetToolTip(this.btnguardar, "Click, para Registrar el Articulo");
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(73, 495);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(62, 16);
            this.lblcantidad.TabIndex = 5;
            this.lblcantidad.Text = "Cantidad";
            this.lblcantidad.Visible = false;
            // 
            // lblprecio
            // 
            this.lblprecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.Color.White;
            this.lblprecio.Location = new System.Drawing.Point(431, 495);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(57, 16);
            this.lblprecio.TabIndex = 6;
            this.lblprecio.Text = "$ Precio";
            this.lblprecio.Visible = false;
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(217, 495);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 16);
            this.lblnombre.TabIndex = 7;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Visible = false;
            // 
            // frmMercancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(747, 607);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dtgViewMercancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMercancias";
            this.Text = "frmMercancias";
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewMercancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ToolTip toolTipMensajeUsuarios;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DataGridView dtgViewMercancias;
    }
}