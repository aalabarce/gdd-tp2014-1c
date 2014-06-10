namespace FrbaCommerce.Historial_Cliente
{
    partial class Historial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sUBASTASUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet1 = new FrbaCommerce.GD1C2014DataSet();
            this.cOMPRASDIRECTASUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRAS_DIRECTAS_USUARIOSTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRAS_DIRECTAS_USUARIOSTableAdapter();
            this.sUBASTAS_USUARIOSTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.SUBASTAS_USUARIOSTableAdapter();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compradorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBASTASUSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDIRECTASUSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendedorDataGridViewTextBoxColumn,
            this.compradorDataGridViewTextBoxColumn,
            this.publicacionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.calificacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.montoUnitarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOMPRASDIRECTASUSUARIOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(667, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el historial que desea ver";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendedorDataGridViewTextBoxColumn1,
            this.compradorDataGridViewTextBoxColumn1,
            this.publicacionDataGridViewTextBoxColumn1,
            this.fechaDataGridViewTextBoxColumn1,
            this.calificacionDataGridViewTextBoxColumn1,
            this.montoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sUBASTASUSUARIOSBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(667, 303);
            this.dataGridView2.TabIndex = 3;
            // 
            // sUBASTASUSUARIOSBindingSource
            // 
            this.sUBASTASUSUARIOSBindingSource.DataMember = "SUBASTAS_USUARIOS";
            this.sUBASTASUSUARIOSBindingSource.DataSource = this.gD1C2014DataSet1;
            // 
            // gD1C2014DataSet1
            // 
            this.gD1C2014DataSet1.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRASDIRECTASUSUARIOSBindingSource
            // 
            this.cOMPRASDIRECTASUSUARIOSBindingSource.DataMember = "COMPRAS_DIRECTAS_USUARIOS";
            this.cOMPRASDIRECTASUSUARIOSBindingSource.DataSource = this.gD1C2014DataSet1;
            // 
            // cOMPRAS_DIRECTAS_USUARIOSTableAdapter
            // 
            this.cOMPRAS_DIRECTAS_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // sUBASTAS_USUARIOSTableAdapter
            // 
            this.sUBASTAS_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorDataGridViewTextBoxColumn.Width = 78;
            // 
            // compradorDataGridViewTextBoxColumn
            // 
            this.compradorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.compradorDataGridViewTextBoxColumn.DataPropertyName = "Comprador";
            this.compradorDataGridViewTextBoxColumn.HeaderText = "Comprador";
            this.compradorDataGridViewTextBoxColumn.Name = "compradorDataGridViewTextBoxColumn";
            this.compradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.compradorDataGridViewTextBoxColumn.Width = 83;
            // 
            // publicacionDataGridViewTextBoxColumn
            // 
            this.publicacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.publicacionDataGridViewTextBoxColumn.DataPropertyName = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.HeaderText = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.Name = "publicacionDataGridViewTextBoxColumn";
            this.publicacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicacionDataGridViewTextBoxColumn.Width = 87;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // calificacionDataGridViewTextBoxColumn
            // 
            this.calificacionDataGridViewTextBoxColumn.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.Name = "calificacionDataGridViewTextBoxColumn";
            this.calificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.calificacionDataGridViewTextBoxColumn.Width = 70;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 60;
            // 
            // montoUnitarioDataGridViewTextBoxColumn
            // 
            this.montoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Monto_Unitario";
            this.montoUnitarioDataGridViewTextBoxColumn.HeaderText = "Monto Unitario";
            this.montoUnitarioDataGridViewTextBoxColumn.Name = "montoUnitarioDataGridViewTextBoxColumn";
            this.montoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoUnitarioDataGridViewTextBoxColumn.Width = 60;
            // 
            // vendedorDataGridViewTextBoxColumn1
            // 
            this.vendedorDataGridViewTextBoxColumn1.DataPropertyName = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn1.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn1.Name = "vendedorDataGridViewTextBoxColumn1";
            this.vendedorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // compradorDataGridViewTextBoxColumn1
            // 
            this.compradorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.compradorDataGridViewTextBoxColumn1.DataPropertyName = "Comprador";
            this.compradorDataGridViewTextBoxColumn1.HeaderText = "Comprador";
            this.compradorDataGridViewTextBoxColumn1.Name = "compradorDataGridViewTextBoxColumn1";
            this.compradorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.compradorDataGridViewTextBoxColumn1.Width = 83;
            // 
            // publicacionDataGridViewTextBoxColumn1
            // 
            this.publicacionDataGridViewTextBoxColumn1.DataPropertyName = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn1.HeaderText = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn1.Name = "publicacionDataGridViewTextBoxColumn1";
            this.publicacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.publicacionDataGridViewTextBoxColumn1.Width = 200;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn1.Width = 75;
            // 
            // calificacionDataGridViewTextBoxColumn1
            // 
            this.calificacionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calificacionDataGridViewTextBoxColumn1.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn1.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn1.Name = "calificacionDataGridViewTextBoxColumn1";
            this.calificacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.calificacionDataGridViewTextBoxColumn1.Width = 86;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 62;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 399);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Historial";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBASTASUSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDIRECTASUSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD1C2014DataSet gD1C2014DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cOMPRASDIRECTASUSUARIOSBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRAS_DIRECTAS_USUARIOSTableAdapter cOMPRAS_DIRECTAS_USUARIOSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.SUBASTAS_USUARIOSTableAdapter sUBASTAS_USUARIOSTableAdapter;
        private System.Windows.Forms.BindingSource sUBASTASUSUARIOSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn compradorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
    }
}