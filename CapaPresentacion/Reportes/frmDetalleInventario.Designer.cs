namespace CapaPresentacion
{
    partial class frmDetalleInventario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.paMostrarInventariosDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new CapaPresentacion.DataSetPrincipal();
            this.paMostrarInventariosDetalleTableAdapter = new CapaPresentacion.DataSetPrincipalTableAdapters.paMostrarInventariosDetalleTableAdapter();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.lblthisTitulo = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paMostrarInventariosDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            this.panelContenedor.SuspendLayout();
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
            this.panel1.Controls.Add(this.lblthisTitulo);
            this.panel1.Size = new System.Drawing.Size(961, 37);
            this.panel1.Controls.SetChildIndex(this.pictureboxcerrar, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBoxmaximizar, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBoxnormal, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBoxminimizar, 0);
            this.panel1.Controls.SetChildIndex(this.lbltitulo, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBoxImgIcon, 0);
            this.panel1.Controls.SetChildIndex(this.lblthisTitulo, 0);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Visible = false;
            // 
            // paMostrarInventariosDetalleBindingSource
            // 
            this.paMostrarInventariosDetalleBindingSource.DataMember = "paMostrarInventariosDetalle";
            this.paMostrarInventariosDetalleBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paMostrarInventariosDetalleTableAdapter
            // 
            this.paMostrarInventariosDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.reportViewer1);
            this.panelContenedor.Location = new System.Drawing.Point(0, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(960, 435);
            this.panelContenedor.TabIndex = 1;
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresar.ForeColor = System.Drawing.Color.White;
            this.lblRegresar.Image = global::CapaPresentacion.Properties.Resources.ic_regresar32px;
            this.lblRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRegresar.Location = new System.Drawing.Point(248, 487);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(134, 23);
            this.lblRegresar.TabIndex = 2;
            this.lblRegresar.Text = "      Regresar";
            this.lblRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipmensaje.SetToolTip(this.lblRegresar, "Regresar al Proceso de Inventario");
            this.lblRegresar.Click += new System.EventHandler(this.lblRegresar_Click);
            this.lblRegresar.MouseLeave += new System.EventHandler(this.lblRegresar_MouseLeave);
            this.lblRegresar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblRegresar_MouseMove);
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFinalizar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizar.ForeColor = System.Drawing.Color.White;
            this.lblFinalizar.Image = global::CapaPresentacion.Properties.Resources.ic_finalizarw32;
            this.lblFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFinalizar.Location = new System.Drawing.Point(471, 487);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(241, 23);
            this.lblFinalizar.TabIndex = 3;
            this.lblFinalizar.Text = "     Finalizar Inventario";
            this.lblFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipmensaje.SetToolTip(this.lblFinalizar, "Finalizar el Proceso de Inventario");
            this.lblFinalizar.Click += new System.EventHandler(this.lblFinalizar_Click);
            this.lblFinalizar.MouseLeave += new System.EventHandler(this.lblFinalizar_MouseLeave);
            this.lblFinalizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFinalizar_MouseMove);
            // 
            // lblthisTitulo
            // 
            this.lblthisTitulo.AutoSize = true;
            this.lblthisTitulo.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthisTitulo.ForeColor = System.Drawing.Color.White;
            this.lblthisTitulo.Location = new System.Drawing.Point(305, 1);
            this.lblthisTitulo.Name = "lblthisTitulo";
            this.lblthisTitulo.Size = new System.Drawing.Size(348, 33);
            this.lblthisTitulo.TabIndex = 6;
            this.lblthisTitulo.Text = "Resultado de Inventario";
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.White;
            this.lblCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCerrar.Location = new System.Drawing.Point(443, 487);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(75, 23);
            this.lblCerrar.TabIndex = 4;
            this.lblCerrar.Text = "Cerrar";
            this.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipmensaje.SetToolTip(this.lblCerrar, "Cerrar Detalle de Inventario");
            this.lblCerrar.Visible = false;
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            this.lblCerrar.MouseLeave += new System.EventHandler(this.lblCerrar_MouseLeave);
            this.lblCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCerrar_MouseMove);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.paMostrarInventariosDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptInventarioDetalles.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(960, 435);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmDetalleInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(961, 529);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.lblFinalizar);
            this.Controls.Add(this.lblRegresar);
            this.Controls.Add(this.panelContenedor);
            this.Name = "frmDetalleInventario";
            this.Text = "frmDetalleInventario";
            this.Load += new System.EventHandler(this.frmDetalleInventario_Load);
            this.Controls.SetChildIndex(this.panelContenedor, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblRegresar, 0);
            this.Controls.SetChildIndex(this.lblFinalizar, 0);
            this.Controls.SetChildIndex(this.lblCerrar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnormal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paMostrarInventariosDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource paMostrarInventariosDetalleBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.paMostrarInventariosDetalleTableAdapter paMostrarInventariosDetalleTableAdapter;
        private System.Windows.Forms.Panel panelContenedor;
       // private Microsoft.Reporting.WinForms.ReportViewer reportViewerInventario;
        private System.Windows.Forms.Label lblRegresar;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.Label lblthisTitulo;
        private System.Windows.Forms.Label lblCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}