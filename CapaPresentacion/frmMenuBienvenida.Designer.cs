namespace CapaPresentacion
{
    partial class frmMenuBienvenida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblinventariorecientes = new System.Windows.Forms.Label();
            this.dtgviewhistorial = new System.Windows.Forms.DataGridView();
            this.lblcrearinventario = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblHistorialInventarios = new System.Windows.Forms.Label();
            this.lblColmados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewhistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxcerrar
            // 
            this.pictureboxcerrar.Location = new System.Drawing.Point(577, 0);
            this.toolTipmensaje.SetToolTip(this.pictureboxcerrar, "Cerrar");
            this.pictureboxcerrar.Click += new System.EventHandler(this.pictureboxcerrar_Click);
            // 
            // pictureBoxmaximizar
            // 
            this.pictureBoxmaximizar.Location = new System.Drawing.Point(543, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxmaximizar, "Maximizar");
            // 
            // pictureBoxminimizar
            // 
            this.pictureBoxminimizar.Location = new System.Drawing.Point(475, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxminimizar, "Minimizar");
            // 
            // pictureBoxnormal
            // 
            this.pictureBoxnormal.Location = new System.Drawing.Point(509, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxnormal, "Normal");
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(613, 37);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Location = new System.Drawing.Point(169, 0);
            // 
            // lblinventariorecientes
            // 
            this.lblinventariorecientes.AutoSize = true;
            this.lblinventariorecientes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinventariorecientes.ForeColor = System.Drawing.Color.White;
            this.lblinventariorecientes.Location = new System.Drawing.Point(8, 57);
            this.lblinventariorecientes.Name = "lblinventariorecientes";
            this.lblinventariorecientes.Size = new System.Drawing.Size(174, 23);
            this.lblinventariorecientes.TabIndex = 1;
            this.lblinventariorecientes.Text = "Inventarios Recientes:";
            // 
            // dtgviewhistorial
            // 
            this.dtgviewhistorial.AllowUserToAddRows = false;
            this.dtgviewhistorial.AllowUserToDeleteRows = false;
            this.dtgviewhistorial.AllowUserToResizeColumns = false;
            this.dtgviewhistorial.AllowUserToResizeRows = false;
            this.dtgviewhistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgviewhistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dtgviewhistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgviewhistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgviewhistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgviewhistorial.ColumnHeadersVisible = false;
            this.dtgviewhistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgviewhistorial.Location = new System.Drawing.Point(12, 83);
            this.dtgviewhistorial.MultiSelect = false;
            this.dtgviewhistorial.Name = "dtgviewhistorial";
            this.dtgviewhistorial.ReadOnly = true;
            this.dtgviewhistorial.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgviewhistorial.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgviewhistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgviewhistorial.Size = new System.Drawing.Size(245, 186);
            this.dtgviewhistorial.TabIndex = 5;
            this.dtgviewhistorial.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgviewhistorial_CellMouseMove);
            // 
            // lblcrearinventario
            // 
            this.lblcrearinventario.AutoSize = true;
            this.lblcrearinventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcrearinventario.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrearinventario.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblcrearinventario.Image = global::CapaPresentacion.Properties.Resources.ic_save22;
            this.lblcrearinventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcrearinventario.Location = new System.Drawing.Point(286, 80);
            this.lblcrearinventario.Name = "lblcrearinventario";
            this.lblcrearinventario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.lblcrearinventario.Size = new System.Drawing.Size(272, 40);
            this.lblcrearinventario.TabIndex = 0;
            this.lblcrearinventario.Text = "      Crear nuevo Inventario";
            this.lblcrearinventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblcrearinventario.Click += new System.EventHandler(this.lblcrearinventario_Click);
            this.lblcrearinventario.MouseLeave += new System.EventHandler(this.lblcrearinventario_MouseLeave);
            this.lblcrearinventario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblcrearinventario_MouseMove);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAyuda.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAyuda.Image = global::CapaPresentacion.Properties.Resources.ic_ayuda32;
            this.lblAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAyuda.Location = new System.Drawing.Point(286, 200);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Padding = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.lblAyuda.Size = new System.Drawing.Size(117, 40);
            this.lblAyuda.TabIndex = 4;
            this.lblAyuda.Text = "      Ayuda ";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAyuda.MouseLeave += new System.EventHandler(this.lblAyuda_MouseLeave);
            this.lblAyuda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAyuda_MouseMove);
            // 
            // lblHistorialInventarios
            // 
            this.lblHistorialInventarios.AutoSize = true;
            this.lblHistorialInventarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHistorialInventarios.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialInventarios.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHistorialInventarios.Image = global::CapaPresentacion.Properties.Resources.ic_History;
            this.lblHistorialInventarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHistorialInventarios.Location = new System.Drawing.Point(286, 160);
            this.lblHistorialInventarios.Name = "lblHistorialInventarios";
            this.lblHistorialInventarios.Padding = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.lblHistorialInventarios.Size = new System.Drawing.Size(283, 40);
            this.lblHistorialInventarios.TabIndex = 1;
            this.lblHistorialInventarios.Text = "      Historial de Inventarios";
            this.lblHistorialInventarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHistorialInventarios.Click += new System.EventHandler(this.lblHistorialInventarios_Click);
            this.lblHistorialInventarios.MouseLeave += new System.EventHandler(this.lblHistorialInventarios_MouseLeave);
            this.lblHistorialInventarios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHistorialInventarios_MouseMove);
            // 
            // lblColmados
            // 
            this.lblColmados.AutoSize = true;
            this.lblColmados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColmados.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColmados.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblColmados.Image = global::CapaPresentacion.Properties.Resources.ic_colmado32;
            this.lblColmados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblColmados.Location = new System.Drawing.Point(286, 120);
            this.lblColmados.Name = "lblColmados";
            this.lblColmados.Padding = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.lblColmados.Size = new System.Drawing.Size(140, 40);
            this.lblColmados.TabIndex = 2;
            this.lblColmados.Text = "      Colmados";
            this.lblColmados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblColmados.Click += new System.EventHandler(this.lblColmados_Click);
            this.lblColmados.MouseLeave += new System.EventHandler(this.lblColmados_MouseLeave);
            this.lblColmados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblColmados_MouseMove);
            // 
            // frmMenuBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 320);
            this.Controls.Add(this.lblColmados);
            this.Controls.Add(this.lblHistorialInventarios);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblcrearinventario);
            this.Controls.Add(this.dtgviewhistorial);
            this.Controls.Add(this.lblinventariorecientes);
            this.Name = "frmMenuBienvenida";
            this.Text = "frmMenuBienvenida";
            this.Load += new System.EventHandler(this.frmMenuBienvenida_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblinventariorecientes, 0);
            this.Controls.SetChildIndex(this.dtgviewhistorial, 0);
            this.Controls.SetChildIndex(this.lblcrearinventario, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.Controls.SetChildIndex(this.lblHistorialInventarios, 0);
            this.Controls.SetChildIndex(this.lblColmados, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewhistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinventariorecientes;
        private System.Windows.Forms.DataGridView dtgviewhistorial;
        private System.Windows.Forms.Label lblcrearinventario;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblHistorialInventarios;
        private System.Windows.Forms.Label lblColmados;
    }
}