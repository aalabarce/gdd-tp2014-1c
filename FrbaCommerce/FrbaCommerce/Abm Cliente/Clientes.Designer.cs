namespace FrbaCommerce.Abm_Cliente
{
    partial class Clientes
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
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.gD1C2014DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.CLIENTETableAdapter();
            this.cLIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cLIUSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIAPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIDOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITIPODOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIPISODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIDEPTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLILOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICODPOSTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIFECHANACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICALLENRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIIDDataGridViewTextBoxColumn,
            this.Ver,
            this.Modificar,
            this.Eliminar,
            this.cLIUSUIDDataGridViewTextBoxColumn,
            this.cLINOMBREDataGridViewTextBoxColumn,
            this.cLIAPEDataGridViewTextBoxColumn,
            this.cLIDOCDataGridViewTextBoxColumn,
            this.cLITIPODOCDataGridViewTextBoxColumn,
            this.cLIMAILDataGridViewTextBoxColumn,
            this.cLITELEFONODataGridViewTextBoxColumn,
            this.cLICALLEDataGridViewTextBoxColumn,
            this.cLIPISODataGridViewTextBoxColumn,
            this.cLIDEPTODataGridViewTextBoxColumn,
            this.cLILOCALIDADDataGridViewTextBoxColumn,
            this.cLICODPOSTALDataGridViewTextBoxColumn,
            this.cLIFECHANACDataGridViewTextBoxColumn,
            this.cLICALLENRODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(632, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD1C2014DataSetBindingSource
            // 
            this.gD1C2014DataSetBindingSource.DataSource = this.gD1C2014DataSet;
            this.gD1C2014DataSetBindingSource.Position = 0;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.gD1C2014DataSetBindingSource;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cLIIDDataGridViewTextBoxColumn
            // 
            this.cLIIDDataGridViewTextBoxColumn.DataPropertyName = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.HeaderText = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.Name = "cLIIDDataGridViewTextBoxColumn";
            this.cLIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver Completo";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Width = 80;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 70;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 70;
            // 
            // cLIUSUIDDataGridViewTextBoxColumn
            // 
            this.cLIUSUIDDataGridViewTextBoxColumn.DataPropertyName = "CLI_USU_ID";
            this.cLIUSUIDDataGridViewTextBoxColumn.HeaderText = "CLI_USU_ID";
            this.cLIUSUIDDataGridViewTextBoxColumn.Name = "cLIUSUIDDataGridViewTextBoxColumn";
            this.cLIUSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLINOMBREDataGridViewTextBoxColumn
            // 
            this.cLINOMBREDataGridViewTextBoxColumn.DataPropertyName = "CLI_NOMBRE";
            this.cLINOMBREDataGridViewTextBoxColumn.HeaderText = "CLI_NOMBRE";
            this.cLINOMBREDataGridViewTextBoxColumn.Name = "cLINOMBREDataGridViewTextBoxColumn";
            this.cLINOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIAPEDataGridViewTextBoxColumn
            // 
            this.cLIAPEDataGridViewTextBoxColumn.DataPropertyName = "CLI_APE";
            this.cLIAPEDataGridViewTextBoxColumn.HeaderText = "CLI_APE";
            this.cLIAPEDataGridViewTextBoxColumn.Name = "cLIAPEDataGridViewTextBoxColumn";
            this.cLIAPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIDOCDataGridViewTextBoxColumn
            // 
            this.cLIDOCDataGridViewTextBoxColumn.DataPropertyName = "CLI_DOC";
            this.cLIDOCDataGridViewTextBoxColumn.HeaderText = "CLI_DOC";
            this.cLIDOCDataGridViewTextBoxColumn.Name = "cLIDOCDataGridViewTextBoxColumn";
            this.cLIDOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLITIPODOCDataGridViewTextBoxColumn
            // 
            this.cLITIPODOCDataGridViewTextBoxColumn.DataPropertyName = "CLI_TIPO_DOC";
            this.cLITIPODOCDataGridViewTextBoxColumn.HeaderText = "CLI_TIPO_DOC";
            this.cLITIPODOCDataGridViewTextBoxColumn.Name = "cLITIPODOCDataGridViewTextBoxColumn";
            this.cLITIPODOCDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLITIPODOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIMAILDataGridViewTextBoxColumn
            // 
            this.cLIMAILDataGridViewTextBoxColumn.DataPropertyName = "CLI_MAIL";
            this.cLIMAILDataGridViewTextBoxColumn.HeaderText = "CLI_MAIL";
            this.cLIMAILDataGridViewTextBoxColumn.Name = "cLIMAILDataGridViewTextBoxColumn";
            this.cLIMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLITELEFONODataGridViewTextBoxColumn
            // 
            this.cLITELEFONODataGridViewTextBoxColumn.DataPropertyName = "CLI_TELEFONO";
            this.cLITELEFONODataGridViewTextBoxColumn.HeaderText = "CLI_TELEFONO";
            this.cLITELEFONODataGridViewTextBoxColumn.Name = "cLITELEFONODataGridViewTextBoxColumn";
            this.cLITELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLITELEFONODataGridViewTextBoxColumn.Visible = false;
            // 
            // cLICALLEDataGridViewTextBoxColumn
            // 
            this.cLICALLEDataGridViewTextBoxColumn.DataPropertyName = "CLI_CALLE";
            this.cLICALLEDataGridViewTextBoxColumn.HeaderText = "CLI_CALLE";
            this.cLICALLEDataGridViewTextBoxColumn.Name = "cLICALLEDataGridViewTextBoxColumn";
            this.cLICALLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLICALLEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIPISODataGridViewTextBoxColumn
            // 
            this.cLIPISODataGridViewTextBoxColumn.DataPropertyName = "CLI_PISO";
            this.cLIPISODataGridViewTextBoxColumn.HeaderText = "CLI_PISO";
            this.cLIPISODataGridViewTextBoxColumn.Name = "cLIPISODataGridViewTextBoxColumn";
            this.cLIPISODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIPISODataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIDEPTODataGridViewTextBoxColumn
            // 
            this.cLIDEPTODataGridViewTextBoxColumn.DataPropertyName = "CLI_DEPTO";
            this.cLIDEPTODataGridViewTextBoxColumn.HeaderText = "CLI_DEPTO";
            this.cLIDEPTODataGridViewTextBoxColumn.Name = "cLIDEPTODataGridViewTextBoxColumn";
            this.cLIDEPTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIDEPTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cLILOCALIDADDataGridViewTextBoxColumn
            // 
            this.cLILOCALIDADDataGridViewTextBoxColumn.DataPropertyName = "CLI_LOCALIDAD";
            this.cLILOCALIDADDataGridViewTextBoxColumn.HeaderText = "CLI_LOCALIDAD";
            this.cLILOCALIDADDataGridViewTextBoxColumn.Name = "cLILOCALIDADDataGridViewTextBoxColumn";
            this.cLILOCALIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLILOCALIDADDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLICODPOSTALDataGridViewTextBoxColumn
            // 
            this.cLICODPOSTALDataGridViewTextBoxColumn.DataPropertyName = "CLI_COD_POSTAL";
            this.cLICODPOSTALDataGridViewTextBoxColumn.HeaderText = "CLI_COD_POSTAL";
            this.cLICODPOSTALDataGridViewTextBoxColumn.Name = "cLICODPOSTALDataGridViewTextBoxColumn";
            this.cLICODPOSTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLICODPOSTALDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIFECHANACDataGridViewTextBoxColumn
            // 
            this.cLIFECHANACDataGridViewTextBoxColumn.DataPropertyName = "CLI_FECHA_NAC";
            this.cLIFECHANACDataGridViewTextBoxColumn.HeaderText = "CLI_FECHA_NAC";
            this.cLIFECHANACDataGridViewTextBoxColumn.Name = "cLIFECHANACDataGridViewTextBoxColumn";
            this.cLIFECHANACDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIFECHANACDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLICALLENRODataGridViewTextBoxColumn
            // 
            this.cLICALLENRODataGridViewTextBoxColumn.DataPropertyName = "CLI_CALLE_NRO";
            this.cLICALLENRODataGridViewTextBoxColumn.HeaderText = "CLI_CALLE_NRO";
            this.cLICALLENRODataGridViewTextBoxColumn.Name = "cLICALLENRODataGridViewTextBoxColumn";
            this.cLICALLENRODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLICALLENRODataGridViewTextBoxColumn.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(443, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro 1 (Pendiente)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro 2 (Pendiente)";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gD1C2014DataSetBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIUSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIAPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITIPODOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICALLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIPISODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDEPTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLILOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICODPOSTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIFECHANACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICALLENRODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}