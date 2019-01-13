namespace CapaPresentacion
{
    partial class frmEfectivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.TextBox();
            this.dgViewEfectivos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblmonto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEfectivos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdescripcion.Location = new System.Drawing.Point(109, 514);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(166, 29);
            this.txtdescripcion.TabIndex = 0;
            this.txtdescripcion.Text = "Descripción";
            this.txtdescripcion.Click += new System.EventHandler(this.txtdescripcion_Click);
            this.txtdescripcion.TabStopChanged += new System.EventHandler(this.txtdescripcion_TabStopChanged);
            this.txtdescripcion.Enter += new System.EventHandler(this.txtdescripcion_Enter);
            // 
            // Monto
            // 
            this.Monto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Monto.Location = new System.Drawing.Point(347, 514);
            this.Monto.MaxLength = 8;
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(114, 29);
            this.Monto.TabIndex = 1;
            this.Monto.Text = "$ Monto";
            this.Monto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Monto_MouseClick);
            this.Monto.Enter += new System.EventHandler(this.Monto_Enter);
            this.Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Monto_KeyPress);
            // 
            // dgViewEfectivos
            // 
            this.dgViewEfectivos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgViewEfectivos.AllowUserToAddRows = false;
            this.dgViewEfectivos.AllowUserToDeleteRows = false;
            this.dgViewEfectivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgViewEfectivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgViewEfectivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewEfectivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewEfectivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dgViewEfectivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewEfectivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgViewEfectivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewEfectivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgViewEfectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewEfectivos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgViewEfectivos.EnableHeadersVisualStyles = false;
            this.dgViewEfectivos.Location = new System.Drawing.Point(60, 110);
            this.dgViewEfectivos.MaximumSize = new System.Drawing.Size(700, 400);
            this.dgViewEfectivos.MultiSelect = false;
            this.dgViewEfectivos.Name = "dgViewEfectivos";
            this.dgViewEfectivos.ReadOnly = true;
            this.dgViewEfectivos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgViewEfectivos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgViewEfectivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewEfectivos.Size = new System.Drawing.Size(626, 343);
            this.dgViewEfectivos.TabIndex = 14;
            this.dgViewEfectivos.TabStop = false;
            this.dgViewEfectivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewEfectivos_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.ic_saveG;
            this.btnGuardar.Location = new System.Drawing.Point(529, 498);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 67);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.White;
            this.lbldescripcion.Location = new System.Drawing.Point(106, 498);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(80, 16);
            this.lbldescripcion.TabIndex = 18;
            this.lbldescripcion.Text = "Descripción";
            this.lbldescripcion.Visible = false;
            // 
            // lblmonto
            // 
            this.lblmonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmonto.AutoSize = true;
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = System.Drawing.Color.White;
            this.lblmonto.Location = new System.Drawing.Point(344, 498);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(55, 16);
            this.lblmonto.TabIndex = 17;
            this.lblmonto.Text = "$ Monto";
            this.lblmonto.Visible = false;
            // 
            // frmEfectivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(747, 607);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgViewEfectivos);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.Monto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEfectivos";
            this.Text = "frmEfectivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEfectivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.DataGridView dgViewEfectivos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblmonto;
    }
}