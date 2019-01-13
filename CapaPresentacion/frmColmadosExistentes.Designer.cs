namespace CapaPresentacion
{
    partial class frmColmadosExistentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgViewColmado = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.cboxbuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewColmado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxcerrar
            // 
            this.pictureboxcerrar.Location = new System.Drawing.Point(881, 0);
            this.toolTipmensaje.SetToolTip(this.pictureboxcerrar, "Cerrar");
            this.pictureboxcerrar.Click += new System.EventHandler(this.pictureboxcerrar_Click);
            // 
            // pictureBoxmaximizar
            // 
            this.pictureBoxmaximizar.Location = new System.Drawing.Point(847, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxmaximizar, "Maximizar");
            // 
            // pictureBoxminimizar
            // 
            this.pictureBoxminimizar.Location = new System.Drawing.Point(779, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxminimizar, "Minimizar");
            // 
            // pictureBoxnormal
            // 
            this.pictureBoxnormal.Location = new System.Drawing.Point(813, 0);
            this.toolTipmensaje.SetToolTip(this.pictureBoxnormal, "Normal");
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(917, 37);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Location = new System.Drawing.Point(380, 0);
            this.lbltitulo.Size = new System.Drawing.Size(155, 34);
            this.lbltitulo.Text = "Colmados";
            // 
            // pictureBoxImgIcon
            // 
            this.pictureBoxImgIcon.Image = global::CapaPresentacion.Properties.Resources.ic_colmado32;
            this.pictureBoxImgIcon.Size = new System.Drawing.Size(32, 35);
            // 
            // dtgViewColmado
            // 
            this.dtgViewColmado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtgViewColmado.AllowUserToAddRows = false;
            this.dtgViewColmado.AllowUserToDeleteRows = false;
            this.dtgViewColmado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgViewColmado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgViewColmado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgViewColmado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgViewColmado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dtgViewColmado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgViewColmado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgViewColmado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgViewColmado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgViewColmado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewColmado.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgViewColmado.EnableHeadersVisualStyles = false;
            this.dtgViewColmado.Location = new System.Drawing.Point(23, 117);
            this.dtgViewColmado.MultiSelect = false;
            this.dtgViewColmado.Name = "dtgViewColmado";
            this.dtgViewColmado.ReadOnly = true;
            this.dtgViewColmado.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgViewColmado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgViewColmado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViewColmado.Size = new System.Drawing.Size(870, 234);
            this.dtgViewColmado.StandardTab = true;
            this.dtgViewColmado.TabIndex = 0;
            this.dtgViewColmado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewColmado_CellClick);
            this.dtgViewColmado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgViewColmado_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::CapaPresentacion.Properties.Resources.ic_save22;
            this.btnAdd.Location = new System.Drawing.Point(133, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir Colmado";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.ForeColor = System.Drawing.Color.White;
            this.lblbuscar.Location = new System.Drawing.Point(301, 41);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(76, 13);
            this.lblbuscar.TabIndex = 15;
            this.lblbuscar.Text = "Buscar por :";
            this.lblbuscar.Visible = false;
            // 
            // cboxbuscar
            // 
            this.cboxbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.cboxbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxbuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxbuscar.ForeColor = System.Drawing.Color.White;
            this.cboxbuscar.FormattingEnabled = true;
            this.cboxbuscar.Items.AddRange(new object[] {
            "Nombre",
            "Propietario"});
            this.cboxbuscar.Location = new System.Drawing.Point(304, 57);
            this.cboxbuscar.Name = "cboxbuscar";
            this.cboxbuscar.Size = new System.Drawing.Size(104, 26);
            this.cboxbuscar.TabIndex = 6;
            this.cboxbuscar.Visible = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.White;
            this.txtbuscar.Location = new System.Drawing.Point(431, 55);
            this.txtbuscar.MaxLength = 40;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(224, 31);
            this.txtbuscar.TabIndex = 5;
            this.txtbuscar.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::CapaPresentacion.Properties.Resources.ic_buscar50;
            this.btnbuscar.Location = new System.Drawing.Point(261, 50);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 36);
            this.btnbuscar.TabIndex = 4;
            this.toolTipmensaje.SetToolTip(this.btnbuscar, "Buscar");
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.ic_delete32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(594, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 52);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Colmado";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipmensaje.SetToolTip(this.btnEliminar, "Eliminar Registro");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.ic_editar32;
            this.btnEditar.Location = new System.Drawing.Point(363, 372);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 52);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Colmado";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmColmadosExistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 453);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgViewColmado);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.cboxbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Name = "frmColmadosExistentes";
            this.Text = "frmColmadosExistentes";
            this.Load += new System.EventHandler(this.frmColmadosExistentes_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.txtbuscar, 0);
            this.Controls.SetChildIndex(this.cboxbuscar, 0);
            this.Controls.SetChildIndex(this.lblbuscar, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dtgViewColmado, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewColmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViewColmado;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.ComboBox cboxbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;

    }
}