namespace FrbaCommerce.Calificar_Vendedor
{
    partial class BuscarCalificar
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
            this.publicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cOMPRASSINCALIFICARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.cOMPRAS_SIN_CALIFICARTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRAS_SIN_CALIFICARTableAdapter();
            this.compraTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRATableAdapter();
            this.subastas_ganadoresTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.SUBASTAS_GANADORESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSINCALIFICARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
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
            this.publicacionDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dataGridView1.DataSource = this.cOMPRASSINCALIFICARBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(268, 161);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // publicacionDataGridViewTextBoxColumn
            // 
            this.publicacionDataGridViewTextBoxColumn.DataPropertyName = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.HeaderText = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.Name = "publicacionDataGridViewTextBoxColumn";
            this.publicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // cOMPRASSINCALIFICARBindingSource
            // 
            this.cOMPRASSINCALIFICARBindingSource.DataMember = "COMPRAS_SIN_CALIFICAR";
            this.cOMPRASSINCALIFICARBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elija la compra a calificar";
            // 
            // cOMPRAS_SIN_CALIFICARTableAdapter
            // 
            this.cOMPRAS_SIN_CALIFICARTableAdapter.ClearBeforeFill = true;
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // subastas_ganadoresTableAdapter1
            // 
            this.subastas_ganadoresTableAdapter1.ClearBeforeFill = true;
            // 
            // BuscarCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscarCalificar";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.BuscarCalificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSINCALIFICARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource cOMPRASSINCALIFICARBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRAS_SIN_CALIFICARTableAdapter cOMPRAS_SIN_CALIFICARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRATableAdapter compraTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.SUBASTAS_GANADORESTableAdapter subastas_ganadoresTableAdapter1;
    }
}