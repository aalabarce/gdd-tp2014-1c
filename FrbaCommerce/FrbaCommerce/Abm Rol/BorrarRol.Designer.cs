namespace FrbaCommerce.Abm_Rol
{
    partial class BorrarRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rOLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLBAJADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.rOLTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.ROLTableAdapter();
            this.usuariO_ROLTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIO_ROLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, -20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccione el rol que desea modificar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOLIDDataGridViewTextBoxColumn,
            this.rOLNOMBREDataGridViewTextBoxColumn,
            this.rOLBAJADataGridViewCheckBoxColumn,
            this.Seleccionar});
            this.dataGridView1.DataSource = this.rOLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(268, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 76);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Tag = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seleccione el rol que desea eliminar";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // rOLIDDataGridViewTextBoxColumn
            // 
            this.rOLIDDataGridViewTextBoxColumn.DataPropertyName = "ROL_ID";
            this.rOLIDDataGridViewTextBoxColumn.HeaderText = "ROL_ID";
            this.rOLIDDataGridViewTextBoxColumn.Name = "rOLIDDataGridViewTextBoxColumn";
            this.rOLIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOLIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rOLNOMBREDataGridViewTextBoxColumn
            // 
            this.rOLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "ROL_NOMBRE";
            this.rOLNOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.rOLNOMBREDataGridViewTextBoxColumn.Name = "rOLNOMBREDataGridViewTextBoxColumn";
            this.rOLNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOLBAJADataGridViewCheckBoxColumn
            // 
            this.rOLBAJADataGridViewCheckBoxColumn.DataPropertyName = "ROL_BAJA";
            this.rOLBAJADataGridViewCheckBoxColumn.HeaderText = "Baja";
            this.rOLBAJADataGridViewCheckBoxColumn.Name = "rOLBAJADataGridViewCheckBoxColumn";
            this.rOLBAJADataGridViewCheckBoxColumn.ReadOnly = true;
            this.rOLBAJADataGridViewCheckBoxColumn.Visible = false;
            this.rOLBAJADataGridViewCheckBoxColumn.Width = 40;
            // 
            // rOLBindingSource
            // 
            this.rOLBindingSource.DataMember = "ROL";
            this.rOLBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLTableAdapter
            // 
            this.rOLTableAdapter.ClearBeforeFill = true;
            // 
            // usuariO_ROLTableAdapter1
            // 
            this.usuariO_ROLTableAdapter1.ClearBeforeFill = true;
            // 
            // BorrarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "BorrarRol";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.BorrarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource rOLBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.ROLTableAdapter rOLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rOLBAJADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIO_ROLTableAdapter usuariO_ROLTableAdapter1;
    }
}