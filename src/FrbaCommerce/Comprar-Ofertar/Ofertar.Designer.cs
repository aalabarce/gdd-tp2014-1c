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
            this.publicacioN_RUBROTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_RUBROTableAdapter();
            this.rubroTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter();
            this.publicacionTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rUBROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.pUBLICACIONRUBROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pUBSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subastar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pUBUSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFERTASACTIVASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oFERTAS_ACTIVASTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.OFERTAS_ACTIVASTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rUBROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONRUBROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTASACTIVASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // publicacioN_RUBROTableAdapter1
            // 
            this.publicacioN_RUBROTableAdapter1.ClearBeforeFill = true;
            // 
            // rubroTableAdapter1
            // 
            this.rubroTableAdapter1.ClearBeforeFill = true;
            // 
            // publicacionTableAdapter1
            // 
            this.publicacionTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rUBROBindingSource;
            this.comboBox1.DisplayMember = "RUBRO_DESCRIPCION";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "RUBRO_ID";
            // 
            // rUBROBindingSource
            // 
            this.rUBROBindingSource.DataMember = "RUBRO";
            this.rUBROBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLICACIONRUBROBindingSource
            // 
            this.pUBLICACIONRUBROBindingSource.DataMember = "PUBLICACION_RUBRO";
            this.pUBLICACIONRUBROBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rubro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
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
            this.dataGridView1.DataSource = this.oFERTASACTIVASBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 232);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pUBSTOCKDataGridViewTextBoxColumn
            // 
            this.pUBSTOCKDataGridViewTextBoxColumn.DataPropertyName = "PUB_STOCK";
            this.pUBSTOCKDataGridViewTextBoxColumn.HeaderText = "PUB_STOCK";
            this.pUBSTOCKDataGridViewTextBoxColumn.Name = "pUBSTOCKDataGridViewTextBoxColumn";
            this.pUBSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUBPRECIODataGridViewTextBoxColumn
            // 
            this.pUBPRECIODataGridViewTextBoxColumn.DataPropertyName = "PUB_PRECIO";
            this.pUBPRECIODataGridViewTextBoxColumn.HeaderText = "PUB_PRECIO";
            this.pUBPRECIODataGridViewTextBoxColumn.Name = "pUBPRECIODataGridViewTextBoxColumn";
            this.pUBPRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUBDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "PUB_DESCRIPCION";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "PUB_DESCRIPCION";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.Name = "pUBDESCRIPCIONDataGridViewTextBoxColumn";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Subastar
            // 
            this.Subastar.HeaderText = "Subastar";
            this.Subastar.Name = "Subastar";
            this.Subastar.ReadOnly = true;
            this.Subastar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subastar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // oFERTASACTIVASBindingSource
            // 
            this.oFERTASACTIVASBindingSource.DataMember = "OFERTAS_ACTIVAS";
            this.oFERTASACTIVASBindingSource.DataSource = this.gD1C2014DataSetBindingSource;
            // 
            // gD1C2014DataSetBindingSource
            // 
            this.gD1C2014DataSetBindingSource.DataSource = this.gD1C2014DataSet;
            this.gD1C2014DataSetBindingSource.Position = 0;
            // 
            // oFERTAS_ACTIVASTableAdapter
            // 
            this.oFERTAS_ACTIVASTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(117, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 146);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 432);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Ofertar";
            this.Text = "Ofertar";
            this.Load += new System.EventHandler(this.Ofertar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.rUBROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONRUBROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTASACTIVASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_RUBROTableAdapter publicacioN_RUBROTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter rubroTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter publicacionTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource rUBROBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource pUBLICACIONRUBROBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gD1C2014DataSetBindingSource;
        private System.Windows.Forms.BindingSource oFERTASACTIVASBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.OFERTAS_ACTIVASTableAdapter oFERTAS_ACTIVASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Subastar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBUSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}