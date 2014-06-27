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
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cLIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gD1C2014DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.cLIENTETableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.CLIENTETableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver Completo";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Visible = false;
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
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.gD1C2014DataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clientes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nro. doc.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo doc.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(481, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "e-Mail";
            // 
            // cLIIDDataGridViewTextBoxColumn
            // 
            this.cLIIDDataGridViewTextBoxColumn.DataPropertyName = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.HeaderText = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.Name = "cLIIDDataGridViewTextBoxColumn";
            this.cLIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIUSUIDDataGridViewTextBoxColumn
            // 
            this.cLIUSUIDDataGridViewTextBoxColumn.DataPropertyName = "CLI_USU_ID";
            this.cLIUSUIDDataGridViewTextBoxColumn.HeaderText = "CLI_USU_ID";
            this.cLIUSUIDDataGridViewTextBoxColumn.Name = "cLIUSUIDDataGridViewTextBoxColumn";
            this.cLIUSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIUSUIDDataGridViewTextBoxColumn.Visible = false;
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
            this.cLITIPODOCDataGridViewTextBoxColumn.Width = 50;
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
            // gD1C2014DataSetBindingSource
            // 
            this.gD1C2014DataSetBindingSource.DataSource = this.gD1C2014DataSet;
            this.gD1C2014DataSetBindingSource.Position = 0;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(262, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gD1C2014DataSetBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;

    }
}