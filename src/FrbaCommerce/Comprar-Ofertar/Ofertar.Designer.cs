namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Ofertar
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
            this.ofertasLIMITTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.OfertasLIMITTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ofertasLIMITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.pUBLICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLICACIONTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rUBROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rUBROTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter();
            this.publicacionTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter();
            this.pUBSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subastar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pUBUSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasLIMITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUBROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ofertasLIMITTableAdapter1
            // 
            this.ofertasLIMITTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pUBSTOCKDataGridViewTextBoxColumn,
            this.pUBPRECIODataGridViewTextBoxColumn,
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn,
            this.Subastar,
            this.pUBUSUIDDataGridViewTextBoxColumn,
            this.pUBIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ofertasLIMITBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ofertasLIMITBindingSource
            // 
            this.ofertasLIMITBindingSource.DataMember = "OfertasLIMIT";
            this.ofertasLIMITBindingSource.DataSource = this.gD1C2014DataSetBindingSource;
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
            // pUBLICACIONBindingSource
            // 
            this.pUBLICACIONBindingSource.DataMember = "PUBLICACION";
            this.pUBLICACIONBindingSource.DataSource = this.gD1C2014DataSetBindingSource;
            // 
            // pUBLICACIONTableAdapter
            // 
            this.pUBLICACIONTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rUBROBindingSource;
            this.comboBox1.DisplayMember = "RUBRO_DESCRIPCION";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "RUBRO_ID";
            // 
            // rUBROBindingSource
            // 
            this.rUBROBindingSource.DataMember = "RUBRO";
            this.rUBROBindingSource.DataSource = this.gD1C2014DataSetBindingSource;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(127, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(65, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripcion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rubro";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rUBROTableAdapter
            // 
            this.rUBROTableAdapter.ClearBeforeFill = true;
            // 
            // publicacionTableAdapter1
            // 
            this.publicacionTableAdapter1.ClearBeforeFill = true;
            // 
            // pUBSTOCKDataGridViewTextBoxColumn
            // 
            this.pUBSTOCKDataGridViewTextBoxColumn.DataPropertyName = "PUB_STOCK";
            this.pUBSTOCKDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.pUBSTOCKDataGridViewTextBoxColumn.Name = "pUBSTOCKDataGridViewTextBoxColumn";
            this.pUBSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUBPRECIODataGridViewTextBoxColumn
            // 
            this.pUBPRECIODataGridViewTextBoxColumn.DataPropertyName = "PUB_PRECIO";
            this.pUBPRECIODataGridViewTextBoxColumn.HeaderText = "Precio";
            this.pUBPRECIODataGridViewTextBoxColumn.Name = "pUBPRECIODataGridViewTextBoxColumn";
            this.pUBPRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUBDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "PUB_DESCRIPCION";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.Name = "pUBDESCRIPCIONDataGridViewTextBoxColumn";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Subastar
            // 
            this.Subastar.HeaderText = "Ofertar";
            this.Subastar.Name = "Subastar";
            this.Subastar.ReadOnly = true;
            // 
            // pUBUSUIDDataGridViewTextBoxColumn
            // 
            this.pUBUSUIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_USU_ID";
            this.pUBUSUIDDataGridViewTextBoxColumn.HeaderText = "PUB_USU_ID";
            this.pUBUSUIDDataGridViewTextBoxColumn.Name = "pUBUSUIDDataGridViewTextBoxColumn";
            this.pUBUSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pUBUSUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pUBIDDataGridViewTextBoxColumn
            // 
            this.pUBIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_ID";
            this.pUBIDDataGridViewTextBoxColumn.HeaderText = "PUB_ID";
            this.pUBIDDataGridViewTextBoxColumn.Name = "pUBIDDataGridViewTextBoxColumn";
            this.pUBIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pUBIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ofertar";
            this.Text = "Ofertar";
            this.Load += new System.EventHandler(this.Ofertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasLIMITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUBROBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrbaCommerce.GD1C2014DataSetTableAdapters.OfertasLIMITTableAdapter ofertasLIMITTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ofertasLIMITBindingSource;
        private System.Windows.Forms.BindingSource gD1C2014DataSetBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource pUBLICACIONBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter pUBLICACIONTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rUBROBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter rUBROTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter publicacionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Subastar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBUSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBIDDataGridViewTextBoxColumn;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRATableAdapter compraTableAdapter1;
    }
}